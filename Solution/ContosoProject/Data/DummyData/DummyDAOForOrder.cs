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
            _collection = Storage.Orders;
        }

        public ICollection<Order> GetBy(string orderNumber, Status status)
        {
            return !string.IsNullOrWhiteSpace(orderNumber) ? _collection.Where(x => x.OrderNumber == orderNumber).ToList() : _collection.Where(x => x.Status == status).ToList();
        }

        public ICollection<Order> GetByClient(Client client)
        {
            if (_collection.Any(x => x.Client == client))
            {
                return _collection.Where(x => x.Client == client).ToList();
            }
            throw new Exception();
        }

        public ICollection<Order> GetByProduct(Product product)
        {
            if (Contains(product))
            {
                return _collection.Where(x => x.OrderItems.Any(it => it.Product == product)).ToList();
            }
            throw new Exception();
        }
        //TODO fix
        public void AddOrder(Order order, Product product, int quantity)
        {
            if (!Contains(product))
            {
                _collection.Add(new Order(new List<Comment>(), new List<OrderItem>()
                {
                    new OrderItem(product, quantity, product.Price)
                } ));
            }
            throw new Exception();
        }

        private bool Contains(Product product)
        {
            return _collection.Any(x => x.OrderItems.Any(it => it.Product == product));
        }
        //TODO fix
        public void RemoveOrder(Order order, Product product)
        {
            if (Contains(product))
            {
                _collection.First(x => x.OrderItems.Any(it => it.Product == product)).IsActive = false;
            }
            throw new Exception();
        }
        //TODO fix
        public void EditOrder(Order order, Product product, int quantity)
        {
            if (Contains(product))
            {
                var prod = _collection[_collection.IndexOf(_collection.First(x => x.OrderItems.Any(it => it.Product == product)))].OrderItems.First(x => x.Product == product);
                prod.Quantity = quantity;
            }
            throw new Exception();
        }
        [Obsolete("This method was used in case of sum of ALL the orders of target, now use GetAll and Sum for it")]
        public double Sum
        {
            get { return _collection.Sum(x => x.Sum); }
        }
    }
}