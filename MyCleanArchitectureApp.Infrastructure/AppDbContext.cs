using MyCleanArchitectureApp.Domain;
using Microsoft.EntityFrameworkCore;
namespace MyCleanArchitectureApp.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Comedy" },
                new Genre { Id = 3, Name = "Drama" },
                new Genre { Id = 4, Name = "Horror" },
                new Genre { Id = 5, Name = "Sci-Fi" },
                new Genre { Id = 6, Name = "Romance" }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 7, Name = "The Dark Knight", AverageRating = 9.0, GenreId = 1 },
                new Movie { Id = 2, Name = "The Hangover", AverageRating = 7.7, GenreId = 2 },
                new Movie { Id = 3, Name = "Inception", AverageRating = 8.8, GenreId = 5 },
                new Movie { Id = 4, Name = "The Godfather", AverageRating = 9.2, GenreId = 3 },
                new Movie { Id = 5, Name = "It", AverageRating = 6.8, GenreId = 4 },
                new Movie { Id = 6, Name = "Titanic", AverageRating = 7.8, GenreId = 6 } 
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "John Doe" },
                new Customer { Id = 2, Name = "Jane Smith" },
                new Customer { Id = 3, Name = "Michael Johnson" },
                new Customer { Id = 4, Name = "Emily Davis" },
                new Customer { Id = 5, Name = "Sarah Brown" }
            );




        }
    }

}

