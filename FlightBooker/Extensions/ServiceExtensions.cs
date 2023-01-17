using Entities;
using Microsoft.EntityFrameworkCore;

namespace FlightBooker.Extensions;

public static class ServiceExtensions
{
    public static void ConfigurePostgresContext(this IServiceCollection services, 
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("postgresconnection");

        services.AddDbContext<RepositoryContext>(options =>
            options.UseNpgsql(connectionString)
            );

    }

}