using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Product : ExtendedEntity, ICommentable
    {
        private int Quantity { get; set; }
        public double Price { get; set; }
        public string SKU { get; set; }
        public Category Category { get; set; }
        private ICollection<Comment> comments;

        public Product(ICollection<Comment> comments)
        {
            this.comments = comments;
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)comments; }
        }
    }
}
