using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExpenseTracker.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ExpTrackerContext>(options =>
                       options.UseSqlServer(configuration.GetConnectionString("ExpTrackerDbConnection")));

        return services;
    }
}