using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

using MediatR;

using CodeBuildDeploy.Blogs.BusinessLogic.Requests;
using CodeBuildDeploy.Blogs.Contract.Dto;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Handlers
{
    internal sealed class GetAllCategoriesRequestHandler : IRequestHandler<GetAllCategoriesRequest, IList<Category>>
    {
        private readonly ILogger<GetAllCategoriesRequestHandler> _logger;

        private readonly Data.DAContext _session;

        private readonly IMapper _mapper;

        public GetAllCategoriesRequestHandler(Data.DAContext session, IMapper mapper, ILogger<GetAllCategoriesRequestHandler> logger)
        {
            _session = session;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IList<Category>> Handle(GetAllCategoriesRequest request, CancellationToken cancellationToken)
        {
            var dbCategories = await _session.Categories
                    .Include(c => c.Posts)
                    .Where(c => c.Posts.Any()).ToListAsync();

            return dbCategories.Select(_mapper.Map<Category>).ToList();
        }
    }
}
