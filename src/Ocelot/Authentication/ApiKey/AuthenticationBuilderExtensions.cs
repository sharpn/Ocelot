using System;
using Microsoft.AspNetCore.Authentication;

namespace Ocelot.Authentication.Extensions.ApiKey
{
    public static class AuthenticationBuilderExtensions
    {
        public static AuthenticationBuilder AddApiKeySupport(this AuthenticationBuilder builder, Action<ApiKeyAuthenticationOptions> options)
            => builder.AddApiKeySupport(ApiKeyAuthenticationOptions.DefaultScheme, options);

        public static AuthenticationBuilder AddApiKeySupport(this AuthenticationBuilder builder, string authenticationScheme, Action<ApiKeyAuthenticationOptions> options)
        {
            return builder.AddScheme<ApiKeyAuthenticationOptions, ApiKeyAuthenticationHandler>(authenticationScheme, options);
        }
    }
}
