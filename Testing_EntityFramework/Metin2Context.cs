using System.Data.Entity;

namespace Testing_EntityFramework
{
    public class Metin2Context : DbContext
    {
        public DbSet<Product> Prodcuts { get; set; }
    }
}