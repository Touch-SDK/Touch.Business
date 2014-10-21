using System.Collections.Generic;
using Touch.Domain;

namespace Touch.Logic
{
    public abstract class OAuth2Logic : BusinessLogic
    {
        public abstract OAuth2Client GetClient(string clientId);

        public abstract void StoreNonce(OAuth2Nonce nonce);

        public abstract OAuth2Key GetKey(string bucket, string handle);

        public abstract IEnumerable<OAuth2Key> GetKeys(string bucket);

        public abstract void StoreKey(OAuth2Key key);

        public abstract void RemoveKey(string bucket, string handle);
    }
}
