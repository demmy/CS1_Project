using Data.EFRepository;
using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Products;

namespace ContosoUI.CategoryForm
{
    public class CategoryModel
    {
        ProjectContext context = new ProjectContext();
        public readonly ICategoryRepository CategoryRepository;

        public CategoryModel()
        {
            CategoryRepository = new EFCategoryDAO(context);
        }

        public void Save(Category category)
        {
            CategoryRepository.Save(category);
        }

        public void Create(Category category)
        {
            CategoryRepository.Create(category);
        }

        public Category Find(int id)
        {
            return CategoryRepository.Find(id);
        }
    }
}
