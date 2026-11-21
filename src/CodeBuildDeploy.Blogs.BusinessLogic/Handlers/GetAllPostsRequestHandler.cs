using AutoMapper;
using Microsoft.Extensions.Logging;

using MediatR;

using CodeBuildDeploy.Blogs.BusinessLogic.Requests;
using CodeBuildDeploy.Blogs.Contract.Dto;
using CodeBuildDeploy.Blogs.DA.Queries;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Handlers
{
    internal sealed class GetAllPostsRequestHandler : IRequestHandler<GetAllPostsRequest, IList<Post>>
    {
        private readonly ILogger<GetAllPostsRequestHandler> _logger;

        private readonly IMapper _mapper;

        private readonly IQueryRunner<AllPostsQuery, IList<DA.Entities.Post>> _queryRunner;

        public GetAllPostsRequestHandler(IQueryRunner<AllPostsQuery, IList<DA.Entities.Post>> queryRunner, IMapper mapper, ILogger<GetAllPostsRequestHandler> logger)
        {
            _queryRunner = queryRunner;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IList<Post>> Handle(GetAllPostsRequest request, CancellationToken cancellationToken)
        {
            var dbPosts = await _queryRunner.ExecuteAsync(new AllPostsQuery(), cancellationToken);

            return _mapper.Map<IList<Post>>(dbPosts);
        }
    }
}
