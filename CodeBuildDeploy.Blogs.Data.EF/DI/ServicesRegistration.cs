using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using CodeBuildDeploy.Blogs.Data.EF.Queries;
using CodeBuildDeploy.Blogs.Data.Entities;
using CodeBuildDeploy.Blogs.Data.Queries;

namespace CodeBuildDeploy.Blogs.Data.EF
{
    public static class ServicesRegistration
    {
        public static IServiceCollection ConfigureDataServices(this IServiceCollection services)
        {
            services.AddDbContext<DAContext>((serviceProvider, options) =>
                options.UseSqlServer(serviceProvider.GetService<IConfiguration>()!.GetConnectionString("BlogConnection")));

            services.AddScoped<IQueryRunner<AllCategoriesQuery, IList<Category>>, AllCategoriesQueryRunner>();
            return services;
        }
    }
}
