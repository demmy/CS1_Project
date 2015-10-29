using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities.Products;

namespace Data.EFRepository
{
    public class EFCategoryDAO: EFExtendedDAO<Category>, ICategoryRepository
    {
        public ICollection<Category> GetByTitle(string title)
        {
            return (from category in dbContext.Set<Category>()
                where category.Title == title
                select category)
                .ToList();
        }
    }
}
