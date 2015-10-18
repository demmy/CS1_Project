using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Data.StoreData;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Users;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    class NUNitDAOQuerryTests
    {
        [Test]
        public void TestDAOForCategory()
        {
            DummyDAOForCategory category = new DummyDAOForCategory();
        }
        [Test]
        public void TestDAOForClientFindby()
        {
            DummyDAOForClient client = new DummyDAOForClient();
            CollectionAssert.AreEqual(new List<Client> {Storage.Clients[2]}, client.GetBy(new Person() {FirstName = null, MiddleName = null, LastName = "Plemon"}, null));
        }

        [Test]
        public void TestDAOForComment()
        {

        }
        [Test]
        public void TestDAOForOrderGetByClient()
        {
            DummyDAOForOrder order = new DummyDAOForOrder();
            CollectionAssert.AreEqual(new List<Order> { Storage.Orders[0] },order.GetByClient(Storage.Clients[0]));
        }
        [Test]
        public void TestDAOForOrderGetBy()
        {
            DummyDAOForOrder order = new DummyDAOForOrder();
            CollectionAssert.AreEqual(new List<Order> { Storage.Orders[0], Storage.Orders[2] }, order.GetBy(null, Status.Opened));
            //CollectionAssert.AreEqual(new List<Order> { Storage.Orders[0], Storage.Orders[1] }, order.GetBy("a4325", Status.PaidUp));
        }

      
        [Test]
        public void TestDAOForPermission()
        {
            DummyDAOForPermission permission = new DummyDAOForPermission();
            CollectionAssert.AreEqual(new List<Permission> { Storage.Permissions[8]}, permission.GetByTitle("Add Client"));
        }
        [Test]
        public void TestDAOForProduct()
        {
            DummyDAOForProduct product = new DummyDAOForProduct();
            CollectionAssert.AreEqual(new List<Product> { Storage.Products[1] }, product.GetBySKU("sfdfh3"));
        }
        [Test]
        public void TestDAOForProductGetBy()
        {
            DummyDAOForProduct product = new DummyDAOForProduct();
            CollectionAssert.AreEqual(new List<Product> { Storage.Products[1], Storage.Products[4] }, product.GetBy(null, null, Storage.Categories[1]));
            CollectionAssert.AreEqual(new List<Product>(), product.GetBy(null, null, null));
            CollectionAssert.AreEqual(new List<Product> { Storage.Products[0], Storage.Products[3] }, product.GetBy(null, "Table", null));

        }
        [Test]
        public void TestDAOForRole()
        {

        }
        [Test]
        public void TestDAOForUser()
        {
            DummyDAOForUser user = new DummyDAOForUser();
            CollectionAssert.AreEqual(new List<User> {Storage.Users[4] }, user.GetBy("Dir", new Person() { FirstName = null, LastName = null, MiddleName = null }));
            CollectionAssert.AreEqual(new List<User> { Storage.Users[3] }, user.GetBy(null, Storage.Persons[3]));
            
        }
    }
}
