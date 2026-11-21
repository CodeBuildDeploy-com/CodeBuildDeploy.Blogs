using AutoMapper;
using Microsoft.Extensions.Logging;

using MediatR;

using CodeBuildDeploy.Blogs.BusinessLogic.Requests;
using CodeBuildDeploy.Blogs.Contract.Dto;
using CodeBuildDeploy.Blogs.DA.Queries;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Handlers
{
    internal sealed class GetPagedPostsRequestHandler : IRequestHandler<GetPagedPostsRequest, IList<Post>>
    {
        private readonly ILogger<GetPagedPostsRequestHandler> _logger;

        private readonly IMapper _mapper;

        private readonly IQueryRunner<PagedPostsQuery, IList<DA.Entities.Post>> _queryRunner;

        public GetPagedPostsRequestHandler(IQueryRunner<PagedPostsQuery, IList<DA.Entities.Post>> queryRunner, IMapper mapper, ILogger<GetPagedPostsRequestHandler> logger)
        {
            _queryRunner = queryRunner;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IList<Post>> Handle(GetPagedPostsRequest request, CancellationToken cancellationToken)
        {
            var dbPosts = await _queryRunner.ExecuteAsync(new PagedPostsQuery(request.PageNo, request.PageSize), cancellationToken);

            return _mapper.Map<IList<Post>>(dbPosts);
        }
    }
}
