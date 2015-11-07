using Domain.Entities.Clients;
using Domain.Entities.Comments;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Domain.Entities.Orders
{
    public enum Status { All, Opened, PaidUp, Finished, Shipped, Closed }

    public class Order : ExtendedEntity, ICommentable
    {
        private IList<OrderItem> orderItems = new List<OrderItem>();
        public Order(ICollection<Comment> comments, ICollection<OrderItem> orders)
        {
            Comments = comments;
            orderItems = orders.ToList();
        }

        public Order()
        {

        }

        public Client Client { get; set; }
        public Status Status { get; set; }
        public string OrderNumber { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        
        public List<OrderItem> OrderItems
        {
            get 
            { return orderItems.ToList(); }
            set { orderItems = new Collection<OrderItem>(value); }
        }

        public double Sum
        {
            get { return orderItems.Sum(x => x.Price); }
        }
    }
}
