using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities.Products;

namespace ContosoUI.ProductForm
{
    public class ProductModel
    {
        readonly IProductRepository _productRepository = new DummyDAOForProduct();

        public Product Find(int id)
        {
            return _productRepository.Find(id);
        }
    }
}
