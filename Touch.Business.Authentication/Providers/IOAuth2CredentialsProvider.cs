using System;

namespace Touch.Providers
{
    public interface IOAuth2CredentialsProvider
    {
        string ClientId { get; }

        string ClientSecret { get; }

        string CallbackUrl { get; }

        string AccessToken { get; set; }

        string RefreshToken { get; set; }

        DateTime? Expires { get; set; }
    }
}
