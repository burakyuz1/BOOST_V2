using _01_EagerLazyLoading.Models;
using System.Data.Entity;

namespace _01_EagerLazyLoading.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
