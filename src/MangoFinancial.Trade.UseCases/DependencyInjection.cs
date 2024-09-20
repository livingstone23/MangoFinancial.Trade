using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace MangoFinancial.Trade.UseCases;



/// <summary>
/// Class that handle the static method for extend the method IServiceCollection
/// </summary>
public static class DependencyInjection
{


    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {

        //Indicate create the dependency injection fot all object hinting the interface and the class automapper,
        //in this case the assembly is the current assembly
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        //Indicate create the dependency injection for all object hinting the interface and the class MediatR
        //in this case the assembly is the current assembly
        //Register the assembly with an action to register the services
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        return services;
    }

}