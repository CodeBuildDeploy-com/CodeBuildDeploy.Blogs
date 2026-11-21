using MediatR;

using CodeBuildDeploy.Blogs.BusinessLogic.Requests;
using CodeBuildDeploy.Blogs.DA.Queries;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Handlers
{
    internal sealed class GetTotalPostsRequestHandler : IRequestHandler<GetTotalPostsRequest, int>
    {
        private readonly IQueryRunner<TotalPostsQuery, int> _queryRunner;

        public GetTotalPostsRequestHandler(IQueryRunner<TotalPostsQuery, int> queryRunner)
        {
            _queryRunner = queryRunner;
        }

        public async Task<int> Handle(GetTotalPostsRequest request, CancellationToken cancellationToken)
        {
            return await _queryRunner.ExecuteAsync(new TotalPostsQuery(), cancellationToken);
        }
    }
}
