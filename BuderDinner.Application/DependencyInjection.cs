using BuderDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuderDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection serivce)
    {
        serivce.AddScoped<IAuthenticationService, AuthenticationService>();

        return serivce;
    }
}