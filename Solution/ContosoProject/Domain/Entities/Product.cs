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
        public string Title { get; set; }
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

        public override bool Equals(Object obj)
        {
            if (!(obj is Product))
                return false;
            return ((Product)obj).SKU == this.SKU && ((Product)obj).Title == this.Title
                && ((Product)obj).Price == this.Price && ((Product)obj).Category == this.Category;
        }

        public static bool operator ==(Product product1, Product product2)
        {
            return product1.Equals(product2);
        }

        public static bool operator !=(Product product1, Product product2)
        {
            return !product1.Equals(product2);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
