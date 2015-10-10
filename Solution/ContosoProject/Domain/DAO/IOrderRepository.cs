using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Clients;
using Domain.Entities.Products;
using Domain.Entities.Orders;

namespace Domain.DAO
{
    public interface IOrderRepository : IRepository<Order>
    {
        ICollection<Order> GetByClient(Client client);
        ICollection<Order> GetByProduct(Product product);
        ICollection<Order> GetByStatus(Status status);

        void AddOrder(Product product, int quantity);
        bool Contains(Product product);
        void RemoveOrder(Product product);
        void EditOrder(Product product, int quantity);
        double Sum;
    }
}