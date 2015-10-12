using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Comments;

namespace Domain.Entities.Orders
{
    public enum Status { Opened, PaidUp, Finished, Shipped, Closed }

    public class Order : ExtendedEntity, ICommentable
    {        
        Client Client { get; set; }
        Status Status { get; set; }
        public List<OrderItem> orderItems = new List<OrderItem>();
        private ICollection<Comment> comments;

        public Order(ICollection<Comment> comments)
        {
            this.comments = comments;
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
            get { return (IReadOnlyCollection<Comment>)comments; }
        }

        public double Sum
        {
            get { return orderItems.Sum(x => x.Price); }
        }
    }
}
