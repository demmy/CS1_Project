using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities.Products;

namespace Data.EFRepository
{
    public class EFProductDAO: EFExtendedDAO<Product>, IProductRepository
    {
        public ICollection<Product> GetBy(string sku, string title, Category category)
        {
            var result = dbContext.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(sku))
                result = result.Where(product => product.SKU == sku);

            if (!string.IsNullOrWhiteSpace(title))
                result = result.Where(product => product.Title == title);

            if (!Category.IsNullOrEmpty(category))
                result = result.Where(product => product.Category == category);

            return result.ToList();
        }
    }
}
