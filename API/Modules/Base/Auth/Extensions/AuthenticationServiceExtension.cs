using API.Modules.Base.Auth.Services;
using Microsoft.Extensions.DependencyInjection;

namespace API.Modules.Base.Auth.Extensions
{
    public static class AuthenticationServiceExtension
    {
        public static IServiceCollection AddAuthenticationModule(this IServiceCollection services)
        {
            services.AddScoped<IAuthentication, AuthenticationService>();

            return services;
        }
    }
}