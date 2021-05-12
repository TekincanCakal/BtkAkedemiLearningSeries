using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Testing_EntityFramework
{
    public class ProductDal
    {
        public enum ProductColumns
        {
            Id,
            Name,
            UnitPrice,
            StockAmount
        }

        public List<Product> GetAll()
        {
            using (var context = new Metin2Context())
            {
                return context.Prodcuts.ToList();
            }
        }

        //not using for this project
        public List<string> GetColumnNames()
        {
            using (var context = new Metin2Context())
            {
                return context.Database
                    .SqlQuery<string>("SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('Products');").ToList();
            }
        }

        public List<Product> Search(string word, ProductColumns column)
        {
            using (var context = new Metin2Context())
            {
                switch (column)
                {
                    case ProductColumns.Id:
                        return context.Prodcuts.Where(p => p.Id.ToString().StartsWith(word)).ToList();
                    case ProductColumns.Name:
                        return context.Prodcuts.Where(p => p.Name.ToString().StartsWith(word)).ToList();
                    case ProductColumns.StockAmount:
                        return context.Prodcuts.Where(p => p.StockAmount.ToString().StartsWith(word)).ToList();
                    case ProductColumns.UnitPrice:
                        return context.Prodcuts.Where(p => p.UnitPrice.ToString().StartsWith(word)).ToList();
                    default:
                        return null;
                }
            }
        }

        public void Add(Product product)
        {
            using (var context = new Metin2Context())
            {
                //context.Prodcuts.Add(product); this can be use
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (var context = new Metin2Context())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (var context = new Metin2Context())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}