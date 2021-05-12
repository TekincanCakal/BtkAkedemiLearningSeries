using System.Data.Entity;
using Testing_Project1.Entities;

namespace Testing_Project1
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}