using Infrastructure.Persistence.Repository.BlogPost;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostRepository _blogPostRepository;

        public BlogPostController(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }


        // GET all action


        public IActionResult GetAll() 
        { 
            var blogPosts = _blogPostRepository.GetAll();
            return Ok(blogPosts);
        }

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}
