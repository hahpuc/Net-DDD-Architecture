using BuderDinner.Application.Common.Interfaces.Authentication;
using BuderDinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuderDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serivce)
    {
        serivce.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

        return serivce;
    }
}