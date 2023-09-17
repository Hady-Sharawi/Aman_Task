using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class DI
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DBContext>(options => 
            options.UseSqlServer(configuration.
                GetConnectionString("DefaultConnection"),
                    builder => builder.MigrationsAssembly(typeof(DBContext).Assembly.FullName)));

        return services;
    }
}
