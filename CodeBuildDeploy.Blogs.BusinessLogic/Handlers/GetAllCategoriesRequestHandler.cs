using AutoMapper;
using Microsoft.Extensions.Logging;

using MediatR;

using CodeBuildDeploy.Blogs.BusinessLogic.Requests;
using CodeBuildDeploy.Blogs.Contract.Dto;
using CodeBuildDeploy.Blogs.Data.Queries;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Handlers
{
    internal sealed class GetAllCategoriesRequestHandler : IRequestHandler<GetAllCategoriesRequest, IList<Category>>
    {
        private readonly ILogger<GetAllCategoriesRequestHandler> _logger;

        private readonly IQueryRunner<AllCategoriesQuery, IList<Category>> _queryRunner;

        private readonly IMapper _mapper;

        public GetAllCategoriesRequestHandler(IQueryRunner<AllCategoriesQuery, IList<Category>> queryRunner, IMapper mapper, ILogger<GetAllCategoriesRequestHandler> logger)
        {
            _queryRunner = queryRunner;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IList<Category>> Handle(GetAllCategoriesRequest request, CancellationToken cancellationToken)
        {
            var dbCategories = await _queryRunner.ExecuteAsync(new AllCategoriesQuery(), cancellationToken);

            return dbCategories.Select(_mapper.Map<Category>).ToList();
        }
    }
}
