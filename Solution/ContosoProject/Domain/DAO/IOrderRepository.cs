using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;

namespace Domain.DAO
{
    public interface IOrderRepository : IRepositoryExtension<Order>
    {
        ICollection<Order> GetBy(string orderNumber, Status status);
        ICollection<Order> GetByClient(Client client);
        ICollection<Order> GetByProduct(Product product);

        void AddOrder(Order order, Product product, int quantity);
        void RemoveOrder(Order order, Product product);
        void EditOrder(Order order, Product product, int quantity);
    }
}