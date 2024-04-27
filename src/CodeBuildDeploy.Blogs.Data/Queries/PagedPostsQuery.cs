namespace CodeBuildDeploy.Blogs.Data.Queries
{
    public sealed class PagedPostsQuery
    {
        public PagedPostsQuery(int pageNo, int pageSize)
        {
            PageNo = pageNo;
            PageSize = pageSize;
        }

        public int PageNo { get; private set; }

        public int PageSize { get; private set; }
    }
}
