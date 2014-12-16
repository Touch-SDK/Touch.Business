using System.Collections.Generic;
using Touch.Domain;

namespace Touch.Logic
{
    public interface IOAuth2KeyLogic
    {
        OAuth2Key GetKey(string bucket, string handle);

        IEnumerable<OAuth2Key> GetKeys(string bucket);

        void StoreKey(OAuth2Key key);

        void RemoveKey(string bucket, string handle);
    }
}
