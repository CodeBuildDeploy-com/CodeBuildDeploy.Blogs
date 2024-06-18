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

        private readonly IQueryRunner<PostByUrlSlugQuery, DA.Entities.Post> _queryRunner;

        private readonly IMapper _mapper;

        public GetPostByUrlSlugRequestHandler(IQueryRunner<PostByUrlSlugQuery, DA.Entities.Post> queryRunner, IMapper mapper, ILogger<GetPostByUrlSlugRequestHandler> logger)
        {
            _queryRunner = queryRunner;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Post> Handle(GetPostByUrlSlugRequest request, CancellationToken cancellationToken)
        {
            var dbPost = await _queryRunner.ExecuteAsync(new PostByUrlSlugQuery(request.UrlSlug), cancellationToken);

            //return _mapper.Map<Post>(dbPost);

            return await Task.FromResult(new Post
            {
                UrlSlug = dbPost.UrlSlug,
                Title = dbPost.Title,
                ShortDescription = dbPost.ShortDescription,
                Description = dbPost.Description,
                Content = dbPost.Content,
                Published = dbPost.Published,
                PostedOn = dbPost.PostedOn,
                Modified = dbPost.Modified,
                Author = dbPost.Author,
                Category = new Category
                {
                    Name = dbPost.Category.Name,
                    Description = dbPost.Category.Description
                },
                Tags = dbPost.PostTags.Select(pt =>
                            new Tag
                            {
                                Name = pt.Tag.Name,
                                Description = pt.Tag.Description

                            }).ToList()
            });
        }
    }
}
