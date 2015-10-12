using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities.Products;

namespace Data.DummyData
{
    class DummyDAOForProduct: DummyDAO<Product>, IProductRepository
    {
        public ICollection<Product> GetBySKU(string sku)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Product> GetByCategory(Category category)
        {
            throw new System.NotImplementedException();
        }
    }
}
