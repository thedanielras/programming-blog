using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BlogPost: TraceableEntity
    {
        public Guid BlogPostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public BlogPost()
        {

        }

        public BlogPost(Guid blogPostId, string title, string body)
        {
            BlogPostId = blogPostId;
            Title = title;
            Body = body;
        }
    }
}
