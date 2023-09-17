using Application.Behaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DI
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var currentAssembly = typeof(DI).Assembly;

        services.AddMediatR(configs =>
        configs.RegisterServicesFromAssembly(currentAssembly));

        services.AddValidatorsFromAssembly(currentAssembly);

        // Container
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehavior<,>));
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
        //services.AddScoped<IBaseService, BaseService>();

        return services;
    }
}
