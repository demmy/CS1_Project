using Domain.Entities.Clients;
using Domain.Entities.Comments;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.Orders
{
    public enum Status { Opened, PaidUp, Finished, Shipped, Closed }

    public class Order : ExtendedEntity, ICommentable
    {        
        public Client Client { get; set; }
        public Status Status { get; set; }
        public string OrderNumber { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        private List<OrderItem> orderItems;

        public Order(ICollection<Comment> comments, List<OrderItem> orders)
        {
            Comments = comments;
            orderItems = orders;
        }

        public Order()
        {
            
        }

        public List<OrderItem> OrderItems
        {
            get { return orderItems; }
        }

        public double Sum
        {
            get { return orderItems.Sum(x => x.Price); }
        }
    }
}
