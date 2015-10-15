using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Data.StoreData;
using Domain.Entities;
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

        [TestCase(Conver. person, )]
        public void TestDAOForClientGetByPerson()
        {
            DummyDAOForClient client = new DummyDAOForClient();
            CollectionAssert.AreEqual(new List<Client>() { Storage.Clients[2] }, client.GetByPerson(Storage.Persons[8]));
        }
        [Test]
        public void TestDAOForComment()
        {

        }
        [Test]
        public void TestDAOForOrder()
        {

        }
        [Test]
        public void TestDAOForPermission()
        {

        }
        [Test]
        public void TestDAOForProduct()
        {

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
