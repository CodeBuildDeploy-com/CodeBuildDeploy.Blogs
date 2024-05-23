using Microsoft.OpenApi.Models;

using CodeBuildDeploy.Blogs.BusinessLogic.DI;
using CodeBuildDeploy.Blogs.DA.EF.DI;

namespace CodeBuildDeploy.Blogs.Api.DI;

public static class ServicesRegistration
{
    public static IServiceCollection ConfigureApiServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Code Build Deploy Blogs API v1", Version = "V1" });
        });
        services.ConfigureBusinessLogicServices();
        services.ConfigureDataServices();
        services.AddHealthChecks();

        return services;
    }
}
