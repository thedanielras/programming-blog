using Application.BlogPost.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogPostController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        [Route("/api/blogposts")]
        public async Task<IActionResult> GetAll()
        {
            var getAllBlogPostsQuery = new GetAllBlogPostsQuery();
            var blogPosts = await _mediator.Send(getAllBlogPostsQuery);
            return Ok(blogPosts);
        }

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}
