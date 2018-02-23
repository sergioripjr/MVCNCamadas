using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthwindApp.Domain.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        List<Product> GetAllByCategory(Category category);
    }
}
