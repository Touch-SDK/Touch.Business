using Touch.Domain;

namespace Touch.Providers
{
    public interface IOAuth2Provider
    {
        OAuth2User AuthenticateUser(string userName, string password, string clientId);
    }
}
