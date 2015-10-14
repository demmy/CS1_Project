using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Domain.Entities.Comments;
using Domain.Entities.Products;

namespace DAOQuerryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyDAOForCategory category = new DummyDAOForCategory();
            category.Create(new Category(new List<Comment>()) { Id = 4, IsActive = true, Title = "Ivory", Date = DateTime.Now});
            category.Delete(1);
            var find = category.Find(2);
            var getAllList = category.GetAll();
            var byDateList =  category.GetByDate(DateTime.Now.AddDays(-15));
            var getbyTrue = category.GetByIsActive(true);
            Console.ReadKey();
        }
    }
}
