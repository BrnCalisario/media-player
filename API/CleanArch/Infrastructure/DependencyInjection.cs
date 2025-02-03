using CleanArch.Domain;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DotnetTubeDbContext>(options => 
        {
            options.UseSqlServer(configuration.GetConnectionString("DotnetTube"));
        });

        services.AddScoped<IBlobFileRepository, BlobFileRepository>();

        return services;
    }
}