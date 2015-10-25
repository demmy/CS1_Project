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

        private List<OrderItem> orderItems;
        private ICollection<Comment> _comments= new List<Comment>();

        public Order(ICollection<Comment> comments, List<OrderItem> orders) : this()
        {
            _comments.ToList().AddRange(comments);
            orderItems = orders;
        }

        public Order()
        {
            _comments.Add(new Comment()
            {
                Author = null,
                Date = DateTime.Now,
                EntityType = EntityType.Order,
                Id = -1,
                IsActive = true,
                Text = string.Format("Client has been added {0}", DateTime.Now.ToShortDateString())
            });
        }

        public List<OrderItem> OrderItems
        {
            get { return orderItems; }
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)_comments; }
        }

        public double Sum
        {
            get { return orderItems.Sum(x => x.Price); }
        }
    }
}
