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

        private readonly IQueryRunner<PagedPostsQuery, IList<DA.Entities.Post>> _queryRunner;

        private readonly IMapper _mapper;

        public GetPagedPostsRequestHandler(IQueryRunner<PagedPostsQuery, IList<DA.Entities.Post>> queryRunner, IMapper mapper, ILogger<GetPagedPostsRequestHandler> logger)
        {
            _queryRunner = queryRunner;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IList<Post>> Handle(GetPagedPostsRequest request, CancellationToken cancellationToken)
        {
            var dbPosts = await _queryRunner.ExecuteAsync(new PagedPostsQuery(request.PageNo, request.PageSize), cancellationToken);

            //return dbPosts.Select(_mapper.Map<Post>).ToList();

            return dbPosts.Select(
            x => new Post
            {
                UrlSlug = x.UrlSlug,
                Title = x.Title,
                ShortDescription = x.ShortDescription,
                Description = x.Description,
                Content = x.Content,
                Published = x.Published,
                PostedOn = x.PostedOn,
                Modified = x.Modified,
                Category = new Category
                {
                    Name = x.Category.Name,
                    Description = x.Category.Description
                },
                Tags = x.PostTags.Select(pt =>
                            new Tag
                            {
                                Name = pt.Tag.Name,
                                Description = pt.Tag.Description

                            }).ToList()
            }).ToList();
        }
    }
}
