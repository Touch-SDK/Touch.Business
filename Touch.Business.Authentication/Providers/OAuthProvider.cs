using System.Text;
using Touch.Domain;
using Touch.Persistence;
using Touch.Serialization;

namespace Touch.Providers
{
    sealed public class OAuthProvider : IOAuthProvider
    {
        #region Dependencies
        public IBlob Blob { private get; set; }
        public ISerializer Serializer { private get; set; }
        public IEncoder Encoder { private get; set; }
        #endregion

        #region Data
        private OAuthCredentials _activeCredentials;
        private readonly object _lock = new object();
        #endregion

        #region IOAuthProvider members
        public OAuthCredentials CurrentUser
        {
            get
            {
                lock (_lock)
                {
                    if (_activeCredentials == null && HasFacilities)
                    {
                        var data = Blob.Read();

                        if (data == null) return null;

                        var decoded = Encoder.Decode(data);
                        var serialized = Encoding.UTF8.GetString(decoded, 0, decoded.Length);

                        _activeCredentials = Serializer.Deserialize<OAuthCredentials>(serialized);
                    }

                    return _activeCredentials;
                }
            }
            set
            {
                lock (_lock)
                {
                    _activeCredentials = value;

                    if (!HasFacilities) return;

                    if (value == null)
                    {
                        Blob.Write(new byte[0]);
                        return;
                    }

                    var serialized = Serializer.Serialize(value);
                    var data = Encoding.UTF8.GetBytes(serialized);
                    var encoded = Encoder.Encode(data);

                    Blob.Write(encoded);
                }
            }
        }
        #endregion

        #region Helper methods
        private bool HasFacilities
        {
            get { return Blob != null && Serializer != null && Encoder != null; }
        }
        #endregion
    }
}
