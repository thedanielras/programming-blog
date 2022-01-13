using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repository.BlogPost
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly PersonalBlogDbContext _context;

        public BlogPostRepository(PersonalBlogDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Domain.Entities.BlogPost> GetAll()
        {
           return _context.BlogPosts.ToList();
        }

        public Domain.Entities.BlogPost? GetById(Guid id)
        {
            return _context.BlogPosts.Where(bp => bp.BlogPostId == id).FirstOrDefault();
        }
    }
}
