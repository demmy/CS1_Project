using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;

namespace Domain.Entities.Products
{
    public class Product : ExtendedEntity, ICommentable
    {
        protected bool Equals(Product other)
        {
            return _comments.SequenceEqual(other._comments) && Quantity == other.Quantity && Price.Equals(other.Price) && string.Equals(Title, other.Title) && Equals(Category, other.Category);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_comments != null ? _comments.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Quantity;
                hashCode = (hashCode*397) ^ Price.GetHashCode();
                hashCode = (hashCode*397) ^ (Title != null ? Title.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Category != null ? Category.GetHashCode() : 0);
                return hashCode;
            }
        }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string SKU { get; set; }
        public Category Category { get; set; }

        private ICollection<Comment> _comments = new List<Comment>()
        {
            new Comment()
            {
                Author = null,
                Date = DateTime.Now,
                EntityType = EntityType.Product,
                Text = string.Format("Product has been added ")
            }
        };

        public Product(ICollection<Comment> comments)
        {
            _comments = comments;
        }

        public Product()
        {
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)_comments; }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Product) obj);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
