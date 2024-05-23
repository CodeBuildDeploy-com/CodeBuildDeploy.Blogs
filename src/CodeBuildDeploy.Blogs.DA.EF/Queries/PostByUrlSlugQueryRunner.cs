using Microsoft.EntityFrameworkCore;

using CodeBuildDeploy.Blogs.DA.Entities;
using CodeBuildDeploy.Blogs.DA.Queries;

namespace CodeBuildDeploy.Blogs.DA.EF.Queries
{
    internal sealed class PostByUrlSlugQueryRunner : IQueryRunner<PostByUrlSlugQuery, Post>
    {
        private readonly DAContext _dbContext;

        public PostByUrlSlugQueryRunner(DAContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Post> ExecuteAsync(PostByUrlSlugQuery query, CancellationToken token)
        {
            var dbPost = await _dbContext.Posts
                .Include(p => p.Category)
                .Include(p => p.PostTags)
                .ThenInclude(pt => pt.Tag)
                .SingleAsync(p => p.UrlSlug == query.UrlSlug);

            return dbPost;
        }
    }
}