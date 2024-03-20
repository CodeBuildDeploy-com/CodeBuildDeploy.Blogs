using MediatR;

using CodeBuildDeploy.Blogs.Contract.Dto;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Requests
{
    public sealed class GetAllPostsRequest : IRequest<IList<Post>>
    {
    }
}
