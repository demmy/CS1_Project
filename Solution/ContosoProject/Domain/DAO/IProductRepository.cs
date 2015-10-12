using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Products;

namespace Domain.DAO
{
    public interface IProductRepository : IRepository<Product>
    {
        ICollection<Product> GetBySKU(string sku);
        ICollection<Product> GetByCategory(Category category);
    }
}