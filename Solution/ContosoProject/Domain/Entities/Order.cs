using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    enum Status { Opened, PaidUp, Finished, Shipped, Closed }

    class Order : ExtendedEntity, ICommentable
    {        
        Client Client { get; set; }
        Status Status { get; set; }
        private List<OrderItem> orderItems;
        private ICollection<Comment> comments;

        public Order(ICollection<Comment> comments)
        {
            this.comments = comments;
        }


        // Let all methods temporarily be here
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

        public double Sum
        {
            get { return orderItems.Sum(x => x.Price); }
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)comments; }
        }
    }
}
