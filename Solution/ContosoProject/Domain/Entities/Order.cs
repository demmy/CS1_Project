using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Order : ExtendedEntity, ICommentable
    {
        private List<OrderItem> orderItems;
        Client Client { get; set; }
        public static ExtendedEntity entityID;
        public static User user;

        public Order(Client client)
            : base(entityID.GetNewID, false, user.GetCurrentUser, DateTime.Now)
        {
            Client = client;
            orderItems = new List<OrderItem>();
        }

        public void AddOrder(Product product, int quantity)
        {
            if (!Contains(product))
                orderItems.Add(new OrderItem(product, quantity, product.Price));
            else
                EditOrder(product, quantity);
        }

        public bool Contains(Product product)
        {
            if (orderItems.Where(x => x.Product == product).Count() > 0) 
                return true;
            else
                return false;
        }

        public void RemoveOrder(Product product)
        {
            orderItems.RemoveAll(x => x.Product == product);
        }

        public void EditOrder(Product product, int quantity)
        {
            double price = product.Price;
            price = orderItems.Where(x => x.Product == product).Select(x => x.Price).First();

            RemoveOrder(product);
            orderItems.Add(new OrderItem(product, quantity, price));
        }

        public IReadOnlyList<Comment> Comments
        {
            get { throw new NotImplementedException(); }
        }


        private sealed class OrderItem
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public OrderItem(Product product, int quantity, double price)
            {
                Product = product;
                Quantity = quantity;
                Price = price;
            }            
        }


    }
}
