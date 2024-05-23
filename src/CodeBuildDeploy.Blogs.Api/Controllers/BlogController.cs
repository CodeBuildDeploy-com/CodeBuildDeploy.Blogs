using Microsoft.AspNetCore.Mvc;

using MediatR;

using CodeBuildDeploy.Blogs.Contract.Dto;
using CodeBuildDeploy.Blogs.BusinessLogic.Requests;

namespace CodeBuildDeploy.Blogs.Api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BlogController : ControllerBase
{
    private readonly ILogger<BlogController> _logger;

    private readonly IMediator _mediator;

    public BlogController(ILogger<BlogController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetAllCategories")]
    public async Task<ActionResult<IList<Category>>> GetAllCategories()
    {
        var categories = await _mediator.Send(new GetAllCategoriesRequest());

        return Ok(categories);
    }

    [HttpGet(Name = "GetAllPosts")]
    public async Task<ActionResult<IList<Post>>> GetAllPosts()
    {
        var posts = await _mediator.Send(new GetAllPostsRequest());

        return Ok(posts);
    }

    [HttpGet(Name = "GetPagedPosts")]
    public async Task<ActionResult<IList<Post>>> GetPagedPosts(int pageNo, int pageSize)
    {
        var posts = await _mediator.Send(new GetPagedPostsRequest(pageNo, pageSize));

        return Ok(posts);
    }

    [HttpGet(Name = "GetPostByUrlSlug")]
    public async Task<ActionResult<Post>> GetPostByUrlSlug(string urlSlug)
    {
        var posts = await _mediator.Send(new GetPostByUrlSlugRequest(urlSlug));

        return Ok(posts);
    }

    [HttpGet(Name = "GetTotalPosts")]
    public async Task<ActionResult<int>> GetTotalPosts()
    {
        var totalPosts = await _mediator.Send(new GetTotalPostsRequest());

        return Ok(totalPosts);
    }
}
