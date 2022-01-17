using Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.BlogPost.Queries.GetAll;

public class GetAllBlogPostsQuery : IRequest<IEnumerable<Domain.Entities.BlogPost>>
{
    
}

public class GetAllBlogPostsQueryHandler : IRequestHandler<GetAllBlogPostsQuery, IEnumerable<Domain.Entities.BlogPost>>
{
    private readonly PersonalBlogDbContext _context;

    public GetAllBlogPostsQueryHandler(PersonalBlogDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Domain.Entities.BlogPost>> Handle(GetAllBlogPostsQuery request, 
                                                                    CancellationToken cancellationToken)
    {
        var blogposts = await _context.BlogPosts.ToListAsync(cancellationToken);
        return blogposts;
    }
}