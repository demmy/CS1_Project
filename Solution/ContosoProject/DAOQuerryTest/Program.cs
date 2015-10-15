using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Users;

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

            DummyDAOForClient client = new DummyDAOForClient();
            var byDnepr = client.GetByCity("Dnepropetrovsk");
            //client.GetByName();
            
            DummyDAOForComment comment = new DummyDAOForComment();
            
            DummyDAOForOrder order = new DummyDAOForOrder();
            var byOpened =  order.GetByStatus(Status.Opened);
            
            DummyDAOForPermission permission = new DummyDAOForPermission();
            var byAddComment = permission.GetByTitle("Add Comment");

            DummyDAOForProduct product = new DummyDAOForProduct();
            var byCategory = product.GetByCategory(((List<Category>)byDateList)[0]);
            var bySKU = product.GetBySKU("fhk32x");
            
            DummyDAOForRole role = new DummyDAOForRole();
            var byPermission = role.GetByPermission(((List<Permission>)byAddComment)[0]);
            var byTitle = role.GetByTitle("Admin");
            
            DummyDAOForUser user = new DummyDAOForUser();
            var byLogin = user.GetByLogin("SecondSimpleAdmin");
            var byRole = user.GetByRole(((List<Role>)(byTitle))[0]);

            Console.ReadKey();
        }
    }
}
