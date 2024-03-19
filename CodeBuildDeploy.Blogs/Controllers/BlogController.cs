using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MediatR;

using CodeBuildDeploy.Blogs.Contract.Dto;
using CodeBuildDeploy.Blogs.BusinessLogic.Requests;

namespace CodeBuildDeploy.Blogs.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BlogController : ControllerBase
{
    private readonly ILogger<BlogController> _logger;

    private readonly Data.EF.DAContext _session;

    private readonly IMediator _mediator;

    public BlogController(ILogger<BlogController> logger, Data.EF.DAContext session, IMediator mediator)
    {
        _logger = logger;
        _session = session;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetAllCategories")]
    public async Task<ActionResult<IList<Category>>> GetAllCategories()
    {
        var categories = await _mediator.Send(new GetAllCategoriesRequest());

        return Ok(categories);
    }

    [HttpGet(Name = "GetAllPosts")]
    public IList<Post> GetAllPosts()
    {
        var dbPosts = _session.Posts
                    .Include(p => p.Category)
                    .Include(p => p.PostTags)
                    .ThenInclude(pt => pt.Tag)
                    .Where(p => p.Published)
                    .OrderByDescending(p => p.PostedOn)
                    .ToList();

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

    [HttpGet(Name = "GetPosts")]
    public IList<Post> GetPosts(int pageNo, int pageSize)
    {
        var dbPosts = _session.Posts
                .Include(p => p.Category)
                .Include(p => p.PostTags)
                .ThenInclude(pt => pt.Tag)
                .Where(p => p.Published)
                .OrderByDescending(p => p.PostedOn)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .ToList();

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

    [HttpGet(Name = "GetPostByUrlSlug")]
    public Post GetPostByUrlSlug(string urlSlug)
    {
        var dbPost = _session.Posts
                .Include(p => p.Category)
                .Include(p => p.PostTags)
                .ThenInclude(pt => pt.Tag)
                .Single(p => p.UrlSlug == urlSlug);

        return new Post
            {
                Id = dbPost.Id,
                UrlSlug = dbPost.UrlSlug,
                Title = dbPost.Title,
                ShortDescription = dbPost.ShortDescription,
                Description = dbPost.Description,
                Content = dbPost.Content,
                Published = dbPost.Published,
                PostedOn = dbPost.PostedOn,
                Modified = dbPost.Modified,
                Category = new Category
                {
                    Id = dbPost.Category.Id,
                    Name = dbPost.Category.Name,
                    Description = dbPost.Category.Description
                },
                Tags = dbPost.PostTags.Select(pt =>
                            new Tag
                            {
                                Id = pt.Tag.Id,
                                Name = pt.Tag.Name,
                                Description = pt.Tag.Description

                            }).ToList()
            };
    }

    [HttpGet(Name = "GetTotalPosts")]
    public int GetTotalPosts()
    {
        return _session.Posts.Count(p => p.Published);
    }
}
