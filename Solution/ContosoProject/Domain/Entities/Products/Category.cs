using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;
using Domain.Entities.Users;

namespace Domain.Entities.Products
{
    /// <summary>
    /// The entity that describes the type of product
    /// </summary>
    public class Category: ExtendedEntity, ICommentable
    {
        public string Title { get; set; }

        private ICollection<Comment> _comments = new List<Comment>()
        {
            new Comment()
            {
                Author = null,
                Date = DateTime.Now,
                EntityType = EntityType.Category,
                Text = string.Format("Category has been added ")
            }
        };

        public Category(ICollection<Comment> comments) : this()
        {
            _comments = comments;
        }

        public Category()
        {
        }

        public static bool IsNullOrEmpty(Category category)
        {
            return category == null || category.Title == "";
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)_comments; }
        }

        public override string ToString()
        {
            return string.Format("{0}", Title);
        }
    }
}
