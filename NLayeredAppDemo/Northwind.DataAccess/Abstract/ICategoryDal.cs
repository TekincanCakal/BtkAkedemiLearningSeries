using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Abstract.EntityFramework
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
