using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
         {
         }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = " Quisque vel lacus ac magna, vehicula sagittis ut non lacus. <br/> Vest",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Appetizer"
            });
        }
    }
}
