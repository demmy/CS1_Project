using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public static class CategoryExtention
    {
        public static bool IsNullOrEmpty(this Category category)
        {
            return category == null || category.Title == "";
        }
    }
}
