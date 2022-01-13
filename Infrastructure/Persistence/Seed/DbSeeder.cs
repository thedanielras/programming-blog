using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seed
{
    public static class DbSeeder
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            Guid samplePost1Id = Guid.Parse("{DBBBC51F-2D6C-4D15-B5E5-0ED49BAD7866}");
            string samplePost1Title = "First sample blog post";
            string samplePost1Description = "# Test heading \n > test quote";

            Guid samplePost2Id = Guid.Parse("{48AE345F-34B5-4A91-A079-2141959FFEED}");
            string samplePost2Title = "Second sample blog post";
            string samplePost2Description = "";


            BlogPost samplePost1 = new BlogPost(samplePost1Id, samplePost1Title, samplePost1Description);
            BlogPost samplePost2 = new BlogPost(samplePost2Id, samplePost2Title, samplePost2Description);

            modelBuilder.Entity<BlogPost>().HasData(samplePost1, samplePost2);

            return modelBuilder;
        }
    }
}
