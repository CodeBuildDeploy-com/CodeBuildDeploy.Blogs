using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using CodeBuildDeploy.Blogs.DA.Entities;
using CodeBuildDeploy.Blogs.DA.Queries;

namespace CodeBuildDeploy.Blogs.DA.EF.Queries
{
    internal sealed class PagedPostsQueryRunner : IQueryRunner<PagedPostsQuery, IList<Post>>
    {
        private readonly DAContext _dbContext;
        private readonly ILogger<PagedPostsQueryRunner> _logger;

        public PagedPostsQueryRunner(DAContext dbContext, ILogger<PagedPostsQueryRunner> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IList<Post>> ExecuteAsync(PagedPostsQuery query, CancellationToken token)
        {
            var dbPosts = await _dbContext.Posts
                .Include(p => p.Category)
                .Include(p => p.PostTags)
                .ThenInclude(pt => pt.Tag)
                .Where(p => p.Published)
                .OrderByDescending(p => p.PostedOn)
                .Skip(query.PageNo * query.PageSize)
                .Take(query.PageSize)
                .ToListAsync();

            _logger.LogInformation($"{dbPosts.Count} data posts to map from the db");

            return dbPosts;
        }
    }
}