using MangoFinancial.Trade.Interfaces.Persistence;
using MangoFinancial.Trade.Persistence.Contexts;
using MangoFinancial.Trade.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace MangoFinancial.Trade.Persistence;



/// <summary>
/// Extension methods for setting up persistence related services in an <see cref="IServiceCollection" />.
/// </summary>
public static class DependencyInjection
{


    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<AuditableEntitySaveChangesInterceptor>();

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("TradingConnection"),
                builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        ///Enable the use of the IApplicationDbContext interface
        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        return services;

    }


}