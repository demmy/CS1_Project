using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities.Products;

namespace Data.EFData
{
    class EFDAOForProduct<T> : EFDAO<Product>, IProductRepository
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
