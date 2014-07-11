using System;
using System.Text;

using Touch.Domain;
using Touch.Persistence;
using Touch.Serialization;

namespace Touch.Providers
{
    /// <summary>
    /// Credentials provider.
    /// </summary>
    sealed public class ProviderCredentials : AbstractProviderCredentials
    {
        #region .ctor
        public ProviderCredentials(IBlob blob, ISerializer serializer, IEncoder encoder)
        {
            if (blob == null) throw new ArgumentNullException("blob");
            Blob = blob;

            if (serializer == null) throw new ArgumentNullException("serializer");
            Serializer = serializer;

            if (encoder == null) throw new ArgumentNullException("encoder");
            Encoder = encoder;

            ActiveCredentials = ReadCredentials();
        }
        #endregion

        #region Data
        private readonly IBlob Blob;
        private readonly ISerializer Serializer;
        private readonly IEncoder Encoder;

        private readonly object _lock = new object();
        #endregion

        #region Abstract methods implementation
        public override void SetCredentials(Credentials credentials)
        {
            lock (_lock)
            {
                ActiveCredentials = credentials;

                if (credentials == null)
                {
                    Blob.Write(new byte[0]);
                    return;
                }

                if (credentials.Consumer != null && (string.IsNullOrEmpty(credentials.Consumer.Key) || string.IsNullOrEmpty(credentials.Consumer.Secret)))
                    credentials.Consumer = null;

                if (credentials.Token != null && (string.IsNullOrEmpty(credentials.Token.Key) || string.IsNullOrEmpty(credentials.Token.Secret)))
                    credentials.Token = null;

                var serialized = Serializer.Serialize(credentials);
                var data = Encoding.UTF8.GetBytes(serialized);
                var encoded = Encoder.Encode(data);

                Blob.Write(encoded);
            }
        }

        protected override Credentials ActiveCredentials { get; set; }

        protected override Credentials ReadCredentials()
        {
            lock (_lock)
            {
                try
                {
                    var data = Blob.Read();

                    if (data == null) return null;

                    var decoded = Encoder.Decode(data);
                    var serialized = Encoding.UTF8.GetString(decoded, 0, decoded.Length);

                    return Serializer.Deserialize<Credentials>(serialized);
                }
                catch
                {
                    return null;
                }
            }
        }
        #endregion
    }
}
