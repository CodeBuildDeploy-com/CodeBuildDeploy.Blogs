using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using CodeBuildDeploy.Blogs.Data.Entities;
using CodeBuildDeploy.Blogs.Data.Queries;

namespace CodeBuildDeploy.Blogs.Data.EF.Queries
{
    internal sealed class AllCategoriesQueryRunner : IQueryRunner<AllCategoriesQuery, IList<Category>>
    {
        private readonly DAContext _dbContext;
        private readonly ILogger<AllCategoriesQueryRunner> _logger;

        public AllCategoriesQueryRunner(DAContext dbContext, ILogger<AllCategoriesQueryRunner> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IList<Category>> ExecuteAsync(AllCategoriesQuery query, CancellationToken token)
        {
            var dbCategories = await _dbContext.Categories
                                        .Include(c => c.Posts)
                                        .Where(c => c.Posts.Any()).ToListAsync();

            _logger.LogInformation($"{dbCategories.Count} data categories to map from the db");

            return dbCategories;
        }
    }
}