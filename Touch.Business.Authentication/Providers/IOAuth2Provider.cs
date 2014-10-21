using Touch.Domain;

namespace Touch.Providers
{
    public interface IOAuth2Provider
    {
        bool ValidateUserCredentials(string userName, string password, string clientId);

        OAuth2User GetUser(string userName, string clientId);
    }
}
