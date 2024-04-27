using CodeBuildDeploy.Blogs.BusinessLogic.DI;
using CodeBuildDeploy.Blogs.Data.EF;

namespace CodeBuildDeploy.Blogs.DI;

public static class ServicesRegistration
{
    public static IServiceCollection ConfigureApiServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.ConfigureBusinessLogicServices();
        services.ConfigureDataServices();

        return services;
    }
}
