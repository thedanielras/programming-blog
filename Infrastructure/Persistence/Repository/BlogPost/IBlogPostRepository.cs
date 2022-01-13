using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Persistence.Repository.BlogPost
{
    public interface IBlogPostRepository
    {
        IEnumerable<Domain.Entities.BlogPost> GetAll();
        Domain.Entities.BlogPost? GetById(Guid id);
    }
}
