namespace CodeBuildDeploy.Blogs.DA.Queries
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
