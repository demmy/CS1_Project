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
        static Person person = Storage.Persons[8];
        [Test]
        public void TestDAOForCategory()
        {
            DummyDAOForCategory category = new DummyDAOForCategory();
        }
        [Test]
        public void TestDAOForClientGetByCity()
        {
            DummyDAOForClient client = new DummyDAOForClient();
            CollectionAssert.AreEqual(Storage.Clients, client.GetByCity("Dnepropetrovsk"));
        }
        [Test]
        public void TestDAOForClientGetByPerson()
        {
            DummyDAOForClient client = new DummyDAOForClient();
            CollectionAssert.AreEqual(new List<Client> {Storage.Clients[2] }, client.GetByPerson(Storage.Persons[8]));
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
            Assert.Throws<Exception>(delegate { order.GetByStatus(Status.Shipped); } );
        }
        [Test]
        public void TestDAOForOrderGetByProduct()
        {
            DummyDAOForOrder order = new DummyDAOForOrder();
            CollectionAssert.AreEqual(new List<Order> { Storage.Orders[0], Storage.Orders[1] }, order.GetByProduct(Storage.Products[0]));
        }

        [Test]
        public void TestDAOForOrderGetByStatus()
        {
            DummyDAOForOrder order = new DummyDAOForOrder();
            CollectionAssert.AreEqual(new List<Order> { Storage.Orders[0], Storage.Orders[2]}, order.GetByStatus(Status.Opened));
        }

        [Test]
        public void TestDAOForPermission()
        {
            DummyDAOForPermission permission = new DummyDAOForPermission();
            CollectionAssert.AreEqual(new List<Permission> { Storage.Permissions[8]}, "Add Client");
        }
        [Test]
        public void TestDAOForProduct()
        {
            DummyDAOForProduct product = new DummyDAOForProduct();
            CollectionAssert.AreEqual(new List<Product> { Storage.Products[1] }, product.GetBySKU("sfdfh3"));
        }
        [Test]
        public void TestDAOForRole()
        {

        }
        [Test]
        public void TestDAOForUser()
        {

        }
    }
}
