using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace CodeBuildDeploy.Blogs.BusinessLogic.DI;

public static class ServicesRegistration
{
    public static IServiceCollection ConfigureBusinessLogicServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}
