using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities.Products;

namespace Data.EFRepository
{
    public class EFProductDAO: EFExtendedDAO<Product>, IProductRepository
    {
        public EFProductDAO(ProjectContext context)
            : base(context)
        {

        }
        /// <summary>
        /// The fuction to get all products that match all not-empty specified datas
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="title"></param>
        /// <param name="category"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Gets the product with specified SKU
        /// </summary>
        /// <param name="sku"></param>
        /// <returns></returns>
        public Product GetBySKU(string sku)
        {
            return dbContext.Products
                .FirstOrDefault(product => product.SKU == sku);
        }
    }
}
