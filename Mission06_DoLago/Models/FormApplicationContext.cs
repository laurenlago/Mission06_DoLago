using Microsoft.EntityFrameworkCore;

namespace Mission06_DoLago.Models
{
    public class FormApplicationContext : DbContext
    {
        public FormApplicationContext(DbContextOptions<FormApplicationContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; } //watch out
        public DbSet <Category > Categories { get; set; }
        
        
       protected override void OnModelCreating(ModelBuilder modelBuilder) //seed data
        {
            modelBuilder.Entity<Category>().HasData(

               new Category { CategoryId = 1, CategoryName="Horror"},
               new Category { CategoryId = 2, CategoryName = "Romance" },
               new Category { CategoryId = 3, CategoryName = "Comedy" },
               new Category { CategoryId = 4, CategoryName = "Action" },
               new Category { CategoryId = 5, CategoryName = "Thriller" }
               ) ;
        }
    }
}
