using System;
using System.Collections.Generic;
using System.Linq;
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
        private ICollection<Comment> _comments = new List<Comment>();

        public Product(ICollection<Comment> comments) : this()
        {
            _comments.ToList().AddRange(comments);
        }

        public Product()
        {
            _comments.Add(new Comment()
            {
                Author = null,
                Date = DateTime.Now,
                EntityType = EntityType.Product,
                Id = -1,
                IsActive = true,
                Text = string.Format("Client has been added {0}", DateTime.Now.ToShortDateString())
            });
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)_comments; }
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
