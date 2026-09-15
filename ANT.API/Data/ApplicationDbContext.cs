using ANT.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ANT.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected ApplicationDbContext()
        //{
        //}

        public DbSet <BlogPost> BlogPosts { get; set; }

        public  DbSet <Category> Categories  { get; set; }

        public DbSet<Segment> Segment { get; set; }






    }
}
