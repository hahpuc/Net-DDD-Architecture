using BuderDinner.Application.Common.Interfaces.Authentication;
using BuderDinner.Application.Common.Interfaces.Services;
using BuderDinner.Infrastructure.Authentication;
using BuderDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuderDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serivce, ConfigurationManager configuration)
    {
        // Configure Appsettings.json
        // Like .env in Nodejs

        // serivce.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        serivce.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        serivce.AddSingleton<IDatetimeProvider, DatetimeProvider>();


        return serivce;
    }
}