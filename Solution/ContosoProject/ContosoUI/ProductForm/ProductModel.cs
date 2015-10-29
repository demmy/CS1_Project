using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
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

        public Product GetBySKU(string sku)
        {
            return _productRepository.GetBySKU(sku);
        }

        public void Save(Product productToSave)
        {
            _productRepository.Save(productToSave);
        }

        public void Create(Product productToSave)
        {
            _productRepository.Create(productToSave);
        }
    }
}
