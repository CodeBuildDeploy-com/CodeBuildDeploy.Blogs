using AutoMapper;
using Microsoft.Extensions.Logging;

using MediatR;

using CodeBuildDeploy.Blogs.BusinessLogic.Requests;
using CodeBuildDeploy.Blogs.Contract.Dto;
using CodeBuildDeploy.Blogs.DA.Queries;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Handlers
{
    internal sealed class GetPostByUrlSlugRequestHandler : IRequestHandler<GetPostByUrlSlugRequest, Post>
    {
        private readonly ILogger<GetPostByUrlSlugRequestHandler> _logger;

        private readonly IMapper _mapper;

        private readonly IQueryRunner<PostByUrlSlugQuery, DA.Entities.Post> _queryRunner;

        public GetPostByUrlSlugRequestHandler(IQueryRunner<PostByUrlSlugQuery, DA.Entities.Post> queryRunner, IMapper mapper, ILogger<GetPostByUrlSlugRequestHandler> logger)
        {
            _queryRunner = queryRunner;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Post> Handle(GetPostByUrlSlugRequest request, CancellationToken cancellationToken)
        {
            var dbPost = await _queryRunner.ExecuteAsync(new PostByUrlSlugQuery(request.UrlSlug), cancellationToken);

            return _mapper.Map<Post>(dbPost);
        }
    }
}
