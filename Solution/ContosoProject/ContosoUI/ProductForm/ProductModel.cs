using Data.Design;
using Domain.DAO;
using Domain.Entities.Products;
using System.Collections.Generic;

namespace ContosoUI.ProductForm
{
    public class ProductModel
    {
        private readonly IRepositoryFacade _facade = new EFRepositoryFacade();
        private readonly IProductRepository _productRepository;
        public readonly ICategoryRepository CategoryRepository;
        public ProductModel()
        {
            _productRepository = _facade.ProductRepository;
            CategoryRepository = _facade.CategoryRepository;
        }

        public Product Find(int id)
        {
            return _productRepository.Find(id);
        }

        public void Save(Product productToSave)
        {
            _productRepository.Save(productToSave);
        }

        public void Create(Product productToSave)
        {
            _productRepository.Create(productToSave);
        }

        public ICollection<Product> GetBy(string sku, string title, Category category)
        {
           return _productRepository.GetBy(sku, title, category);
        }
    }
}
