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
        public EFCategoryDAO(ProjectContext context)
            : base(context)
        {

        }
        /// <summary>
        /// Gets all categories, which title maches the entered title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public ICollection<Category> GetByTitle(string title)
        {
            return (from category in dbContext.Set<Category>()
                where category.Title == title
                select category)
                .ToList();
        }
    }
}
