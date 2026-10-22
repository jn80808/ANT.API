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

        public DbSet<Division> Division { get; set; }


        public DbSet<CategoryNameResult> CategoryNameResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryNameResult>()
                .HasNoKey();
        }

    }
}
