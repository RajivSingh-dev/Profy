using Microsoft.EntityFrameworkCore;

namespace Link_D.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }  
        public DbSet<Post> post { get; set; }  
        public DbSet<Comment> comments { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<Comment>().ToTable("comment");
            modelBuilder.Entity<Post>().ToTable("post");
        }

    }
}
