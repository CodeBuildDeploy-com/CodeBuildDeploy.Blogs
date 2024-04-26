using MediatR;

using CodeBuildDeploy.Blogs.Contract.Dto;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Requests
{
    public sealed class GetPagedPostsRequest : IRequest<IList<Post>>
    {
        public GetPagedPostsRequest(int pageNo, int pageSize)
        {
            PageNo = pageNo;
            PageSize = pageSize;
        }

        public int PageNo { get; private set; }

        public int PageSize { get; private set; }
    }
}
