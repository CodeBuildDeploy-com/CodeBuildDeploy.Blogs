using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using CodeBuildDeploy.Blogs.DA.Queries;

namespace CodeBuildDeploy.Blogs.DA.EF.Queries
{
    internal sealed class TotalPostsQueryRunner : IQueryRunner<TotalPostsQuery, int>
    {
        private readonly DAContext _dbContext;
        private readonly ILogger<TotalPostsQueryRunner> _logger;

        public TotalPostsQueryRunner(DAContext dbContext, ILogger<TotalPostsQueryRunner> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<int> ExecuteAsync(TotalPostsQuery query, CancellationToken token)
        {
            var dbTotalPosts = await _dbContext.Posts.CountAsync(p => p.Published);

            _logger.LogInformation($"{dbTotalPosts} published posts in the db");

            return dbTotalPosts;
        }
    }
}