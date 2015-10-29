using System;
using System.Collections.Generic;
using Domain.Entities.Comments;

namespace Domain.Entities.Products
{
    public class Product : ExtendedEntity, ICommentable
    {
        private int Quantity { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string SKU { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public Product(ICollection<Comment> comments)
        {
            Comments = comments;
        }

        public Product()
        {
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Product product = obj as Product;
            if ((Object)product == null)
                return false;

            return ((Product)obj).Id == this.Id;
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
            return this.Id;
        }
    }
}
