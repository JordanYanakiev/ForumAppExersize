using ForumApp03Infrastructure.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp03Infrastructure.Data
{
    public class ForumAppDbContext : DbContext
    {
        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Post> Posts { get; init; }

        private Post FirstPost { get; set; }
        private Post SecondPost { get; set; }
        private Post ThirdPost { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedPosts();

            modelBuilder
                .Entity<Post>()
                .HasData(FirstPost, SecondPost, ThirdPost);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedPosts()
        {
            FirstPost = new Post()
            {
                Id = 1,
                Title = "Title 01",
                Content = "Content 01"
            };

            SecondPost = new Post()
            {
                Id = 2,
                Title = "Title 02",
                Content = "Content 02"
            };

            ThirdPost = new Post()
            {
                Id = 3,
                Title = "Title 03",
                Content = "Content 03"
            };
        }

       
    }
}
