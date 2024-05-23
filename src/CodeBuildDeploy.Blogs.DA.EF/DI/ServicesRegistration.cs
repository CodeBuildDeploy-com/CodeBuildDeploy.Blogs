using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using CodeBuildDeploy.Blogs.DA.EF.Queries;
using CodeBuildDeploy.Blogs.DA.Entities;
using CodeBuildDeploy.Blogs.DA.Queries;

namespace CodeBuildDeploy.Blogs.DA.EF.DI
{
    public static class ServicesRegistration
    {
        private const string EFMigrationsHistoryTableName = "__EFMigrationsHistory";

        public static IServiceCollection ConfigureDataServices(this IServiceCollection services)
        {
            services.AddDbContext<DAContext>((serviceProvider, options) =>
                options.UseSqlServer(serviceProvider.GetService<IConfiguration>()!.GetConnectionString("BlogConnection"),
                                     x => x.MigrationsHistoryTable(EFMigrationsHistoryTableName, DAContext.SchemaName)));

            services.ConfigureQueryRunners();

            return services;
        }

        public static IServiceCollection ConfigureDataServices(this IServiceCollection services, string migrationsAssemblyName)
        {
            services.AddDbContext<DAContext>((serviceProvider, options) =>
                options.UseSqlServer(serviceProvider.GetService<IConfiguration>()!.GetConnectionString("BlogConnection"),
                                     x => x.MigrationsHistoryTable(EFMigrationsHistoryTableName, DAContext.SchemaName)
                                           .MigrationsAssembly(migrationsAssemblyName)));

            services.ConfigureQueryRunners();

            return services;
        }

        private static IServiceCollection ConfigureQueryRunners(this IServiceCollection services)
        {
            services.AddScoped<IQueryRunner<AllCategoriesQuery, IList<Category>>, AllCategoriesQueryRunner>();
            services.AddScoped<IQueryRunner<AllPostsQuery, IList<Post>>, AllPostsQueryRunner>();
            services.AddScoped<IQueryRunner<PagedPostsQuery, IList<Post>>, PagedPostsQueryRunner>();
            services.AddScoped<IQueryRunner<PostByUrlSlugQuery, Post>, PostByUrlSlugQueryRunner>();
            services.AddScoped<IQueryRunner<TotalPostsQuery, int>, TotalPostsQueryRunner>();

            return services;
        }
    }
}
