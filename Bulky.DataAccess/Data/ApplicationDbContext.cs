using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Harry Potter and the Philosopher's Stone",
                    Description = "Follows the story of Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry",
                    ISBN = "978-0-7475-3269-9",
                    Author = "J. K. Rowling",
                    ListPrice = 12.99,
                    Price = 9.99,
                    Price50 = 8.99,
                    Price100 = 8.49
                },
                new Product
                {
                    Id = 2,
                    Title = "The Testament",
                    Description = "Troy Phelan, an eccentric, reclusive, ruthless billionaire businessman, commits suicide. In order to cut his family out of his will, he makes a fake will a few hours before his suicide, putting his family into that will.",
                    ISBN = "0-09-924502-7",
                    Author = "John Grisham",
                    ListPrice = 13.99,
                    Price = 10.99,
                    Price50 = 9.99,
                    Price100 = 8.99
                },
                new Product
                {
                    Id = 3,
                    Title = "Timeline",
                    Description = "A group of history students travel to 14th-century France to rescue their professor.",
                    ISBN = "0679444815",
                    Author = "Michael Crichton",
                    ListPrice = 11.99,
                    Price = 10.99,
                    Price50 = 9.99,
                    Price100 = 8.99
                }
                );
        }
    }
}
