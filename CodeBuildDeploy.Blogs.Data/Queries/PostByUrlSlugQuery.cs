namespace CodeBuildDeploy.Blogs.Data.Queries
{
    public sealed class PostByUrlSlugQuery
    {
        public PostByUrlSlugQuery(string urlSlug)
        {
            UrlSlug = urlSlug;
        }

        public string UrlSlug { get; private set; }
    }
}
