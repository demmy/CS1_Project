using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;

namespace Data.DummyData
{
    class DummyDAOForOrder : DummyDAOExtension<Order>, IOrderRepository
    {
        public ICollection<Order> GetByClient(Client client)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Order> GetByProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Order> GetByStatus(Status status)
        {
            throw new System.NotImplementedException();
        }

        public void AddOrder(Product product, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveOrder(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void EditOrder(Product product, int quantity)
        {
            throw new System.NotImplementedException();
        }

        public double Sum
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
