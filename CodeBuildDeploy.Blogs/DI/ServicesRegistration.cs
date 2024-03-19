using CodeBuildDeploy.Blogs.BusinessLogic.DI;

namespace CodeBuildDeploy.Blogs.DI;

public static class ServicesRegistration
{
    public static IServiceCollection ConfigureApiServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.ConfigureBusinessLogicServices();

        return services;
    }
}
