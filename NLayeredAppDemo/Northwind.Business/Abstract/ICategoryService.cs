using System.Collections.Generic;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
