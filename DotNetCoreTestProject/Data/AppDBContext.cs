using Microsoft.EntityFrameworkCore;

namespace DotNetCoreTestProject.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Post>? Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => 
            dbContextOptionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=DotNetLocalProject;User ID=BackendUser;Password=12345;Timeout=1024;CommandTimeout=1024;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Post[] postsToSeed = new Post[6];

            for (int i = 1; i <= 6; i++)
            {
                postsToSeed[i - 1] = new Post
                {
                    PostId = i,
                    Title = $"Post {i}",
                    Content = $"This is post {i} and that's it."
                };
            }

            modelBuilder.Entity<Post>().HasData(postsToSeed);
        }
    }
}