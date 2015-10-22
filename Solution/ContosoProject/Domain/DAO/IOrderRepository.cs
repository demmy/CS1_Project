﻿using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;

namespace Domain.DAO
{
    public interface IOrderRepository : IRepositoryExtension<Order>
    {
        Order GetByNumber(string orderNumber);
        ICollection<Order> GetByStatus(Status status); 
        ICollection<Order> GetByClient(Client client);
        ICollection<Order> GetByProduct(Product product);

        void AddOrder(Product product, int quantity);
        bool Contains(Product product);
        void RemoveOrder(Product product);
        void EditOrder(Product product, int quantity);
        double Sum { get; }
    }
}