using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using CodeBuildDeploy.DataAccess;

namespace CodeBuildDeploy.Blogs.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BlogController : ControllerBase
{
    private readonly ILogger<BlogController> _logger;
    private readonly DAContext _session;

    public BlogController(ILogger<BlogController> logger, DAContext session)
    {
        _logger = logger;
        _session = session;
    }

    [HttpGet(Name = "GetAllCategories")]
    public IList<Category> GetAllCategories()
    {
        return _session.Categories
                    .Include(c => c.Posts)
                    .Where(c => c.Posts.Any()).ToList();
    }

    [HttpGet(Name = "GetAllPosts")]
    public IList<Post> GetAllPosts()
    {
        return _session.Posts.Where(p => p.Published)
                    .OrderByDescending(p => p.PostedOn)
                    .ToList();
    }

    [HttpGet(Name = "GetPosts")]
    public IList<Post> GetPosts(int pageNo, int pageSize)
    {
        return _session.Posts
                .Include(p => p.Category)
                .Include(p => p.PostTags)
                .ThenInclude(pt => pt.Tag)
                .Where(p => p.Published)
                .OrderByDescending(p => p.PostedOn)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .ToList();
    }

    [HttpGet(Name = "GetPostByUrlSlug")]
    public Post GetPostByUrlSlug(string urlSlug)
    {
        return _session.Posts
                .Include(p => p.Category)
                .Include(p => p.PostTags)
                .ThenInclude(pt => pt.Tag)
                .Single(p => p.UrlSlug == urlSlug);
    }

    [HttpGet(Name = "GetTotalPosts")]
    public int GetTotalPosts()
    {
        return _session.Posts.Count(p => p.Published);
    }
}
