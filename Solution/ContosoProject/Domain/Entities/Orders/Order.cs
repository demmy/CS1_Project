using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Domain.Entities.Comments;

namespace Domain.Entities.Orders
{
    public enum Status { Undefined, Opened, PaidUp, Finished, Shipped, Closed }

    public class Order : ExtendedEntity, ICommentable
    {        
        public Client Client { get; set; }
        public Status Status { get; set; }
        public string OrderNumber { get; set; }

        private List<OrderItem> orderItems = new List<OrderItem>();

        private List<Comment> _comments = new List<Comment>()
        {
            new Comment()
            {
                Author = null,
                Date = DateTime.Now,
                EntityType = EntityType.Order,
                Text = string.Format("Order has been added ")
            }
        };

        public Order(ICollection<Comment> comments, ICollection<OrderItem> orders)
        {
            _comments = comments.ToList();
            orderItems = orders.ToList();
        }

        public Order()
        {
        }

        public List<OrderItem> OrderItems
        {
            get { return orderItems; }
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return _comments; }
        }

        public double Sum
        {
            get { return orderItems.Sum(x => x.Price); }
        }
    }
}
