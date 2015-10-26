using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using Domain.Entities.Products;

namespace Data.DummyData
{
    public class DummyDAOForOrder : DummyDAOExtension<Order>, IOrderRepository
    {
        public DummyDAOForOrder()
        {
            Collection = Storage.Orders;
        }

        public ICollection<Order> GetBy(string orderNumber, Status status, Client client)
        {
            var result = Collection.AsQueryable();
            if (!string.IsNullOrWhiteSpace(orderNumber))
            {
                return result.Where(x => x.OrderNumber == orderNumber).ToList();
            }
            if (client != null)
            {
                result = result.Where(x => x.Client.Equals(client));
            }
            if (status != Status.Undefined)
            {
                result = result.Where(x => x.Status == status);
            }
            if (!result.SequenceEqual(Collection.AsQueryable()))
            {
                return result.ToList();
            }
            throw new Exception();
        }

        public Order GetByNumber(string orderNumber)
        {
            if (string.IsNullOrWhiteSpace(orderNumber))
                return Collection.FirstOrDefault(x => x.OrderNumber == orderNumber);
            throw new Exception();
        }

        public ICollection<Order> GetByStatus(Status status)
        {
            return Collection.Where(x => x.Status == status).ToList();
        }

        public ICollection<Order> GetByClient(Client client)
        {
            if (Collection.Any(x => x.Client == client))
            {
                return Collection.Where(x => x.Client == client).ToList();
            }
            throw new Exception();
        }

        public ICollection<Order> GetByProduct(Product product)
        {
            if (Contains(product))
            {
                return Collection.Where(x => x.OrderItems.Any(it => it.Product == product)).ToList();
            }
            throw new Exception();
        }

        public void AddOrder(Product product, int quantity)
        {
            if (!Contains(product))
            {
                Collection.Add(new Order(new List<Comment>(), new List<OrderItem>
                {
                    new OrderItem(product, quantity, product.Price)
                }));
            }
            throw new Exception();
        }

        public bool Contains(Product product)
        {
            return Collection.Any(x => x.OrderItems.Any(it => it.Product == product));
        }

        public void RemoveOrder(Product product)
        {
            if (Contains(product))
            {
                Collection.First(x => x.OrderItems.Any(it => it.Product == product)).IsActive = false;
            }
            throw new Exception();
        }

        public void EditOrder(Product product, int quantity)
        {
            if (Contains(product))
            {
                var prod = Collection[Collection.IndexOf(Collection.First(x => x.OrderItems.Any(it => it.Product == product)))].OrderItems.First(x => x.Product == product);
                prod.Quantity = quantity;
            }
            throw new Exception();
        }

        public double Sum
        {
            get { return Collection.Sum(x => x.Sum); }
        }
    }
}