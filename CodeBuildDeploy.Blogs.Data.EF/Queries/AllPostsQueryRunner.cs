using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using CodeBuildDeploy.Blogs.Data.Entities;
using CodeBuildDeploy.Blogs.Data.Queries;

namespace CodeBuildDeploy.Blogs.Data.EF.Queries
{
    internal sealed class AllPostsQueryRunner : IQueryRunner<AllPostsQuery, IList<Post>>
    {
        private readonly DAContext _dbContext;
        private readonly ILogger<AllPostsQueryRunner> _logger;

        public AllPostsQueryRunner(DAContext dbContext, ILogger<AllPostsQueryRunner> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IList<Post>> ExecuteAsync(AllPostsQuery query, CancellationToken token)
        {
            var dbPosts = await _dbContext.Posts
                    .Include(p => p.Category)
                    .Include(p => p.PostTags)
                    .ThenInclude(pt => pt.Tag)
                    .Where(p => p.Published)
                    .OrderByDescending(p => p.PostedOn)
                    .ToListAsync();

            _logger.LogInformation($"{dbPosts.Count} data posts to map from the db");

            return dbPosts;
        }
    }
}