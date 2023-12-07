using Microsoft.EntityFrameworkCore;
using ShortenerAplication.Entities;

namespace ShortenerAplication.Data
{
    public class ShortenerContext : DbContext
    {
        public DbSet<Urls> Urls { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Auth> Auth { get; set; }

        public ShortenerContext(DbContextOptions<ShortenerContext> options) : base(options){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Username = "Admin",
                FirstName = "Admin",
                LastName = "Admin",
                Email = "admin@admin.com",
                Urls = new List<Urls>(),
            });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Default",
                }
            );

            modelBuilder.Entity<Auth>().HasData(
                new Auth
                {
                    Id = 1,
                    Password = "admin22@@pepe",
                    Role = "admin"
                }
            );


        }
    }
}
