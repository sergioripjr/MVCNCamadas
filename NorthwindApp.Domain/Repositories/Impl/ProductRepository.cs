using System.Collections.Generic;
using System.Linq;

namespace NorthwindApp.Domain.Repositories.Impl
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        #region Implementação obrigatória da classe base

        public ProductRepository(NorthwindEntities context) : base(context) { }

        protected override string TableName
        {
            get { return "Products"; }
        }

        protected override string EntitySetName
        {
            get { return "Products"; }
        }

        #endregion

        #region IProductRepository Members

        public List<Product> GetAllByCategory(Category category)
        {
            return category.Products.ToList();
        }

        #endregion

        #region Overrides

        public override Product GetById(int id)
        {
            var product = (from products in _context.Products.Include("Category")
                           where products.Identificador == id
                           select products).FirstOrDefault();
            return product;
        }

        #endregion

              

    }
}
