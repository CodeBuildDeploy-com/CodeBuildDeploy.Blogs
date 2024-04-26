using MediatR;

using CodeBuildDeploy.Blogs.Contract.Dto;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Requests
{
    public sealed class GetPostByUrlSlugRequest : IRequest<Post>
    {
        public GetPostByUrlSlugRequest(string urlSlug)
        {
            UrlSlug = urlSlug;
        }

        public string UrlSlug { get; private set; }
    }
}
