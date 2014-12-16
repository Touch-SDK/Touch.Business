using Touch.Domain;

namespace Touch.Logic
{
    public interface IOAuth2NonceLogic
    {
        bool StoreNonce(OAuth2Nonce nonce);
    }
}
