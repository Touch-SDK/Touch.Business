using Touch.Domain;

namespace Touch.Logic
{
    public interface IOAuth2NonceLogic
    {
        void StoreNonce(OAuth2Nonce nonce);
    }
}
