﻿using Microsoft.EntityFrameworkCore;

namespace Link_D.Models.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> post { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Reply> replies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<Comment>().ToTable("comment");
            modelBuilder.Entity<Post>().ToTable("post");
            modelBuilder.Entity<Reply>().ToTable("reply");

        }

    }
}