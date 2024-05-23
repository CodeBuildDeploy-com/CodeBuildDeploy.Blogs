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

        private readonly IQueryRunner<AllPostsQuery, IList<DA.Entities.Post>> _queryRunner;

        private readonly IMapper _mapper;

        public GetAllPostsRequestHandler(IQueryRunner<AllPostsQuery, IList<DA.Entities.Post>> queryRunner, IMapper mapper, ILogger<GetAllPostsRequestHandler> logger)
        {
            _queryRunner = queryRunner;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IList<Post>> Handle(GetAllPostsRequest request, CancellationToken cancellationToken)
        {
            var dbPosts = await _queryRunner.ExecuteAsync(new AllPostsQuery(), cancellationToken);

            //return dbPosts.Select(_mapper.Map<Post>).ToList();

            return dbPosts.Select(
            x => new Post
            {
                Id = x.Id,
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
                    Id = x.Category.Id,
                    Name = x.Category.Name,
                    Description = x.Category.Description
                },
                Tags = x.PostTags.Select(pt =>
                            new Tag
                            {
                                Id = pt.Tag.Id,
                                Name = pt.Tag.Name,
                                Description = pt.Tag.Description

                            }).ToList()
            }).ToList();
        }
    }
}
