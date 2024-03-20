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
            services.AddScoped<IQueryRunner<AllPostsQuery, IList<Post>>, AllPostsQueryRunner>();
            services.AddScoped<IQueryRunner<PagedPostsQuery, IList<Post>>, PagedPostsQueryRunner>();
            services.AddScoped<IQueryRunner<PostByUrlSlugQuery, Post>, PostByUrlSlugQueryRunner>();
            services.AddScoped<IQueryRunner<TotalPostsQuery, int>, TotalPostsQueryRunner>();
            return services;
        }
    }
}
