using System.Collections.Generic;
using Domain.Entities.Comments;

namespace Domain.Entities.Products
{
    /// <summary>
    /// The entity that describes the type of product
    /// </summary>
    public class Category: ExtendedEntity, ICommentable
    {
        public virtual ICollection<Comment> Comments { get; set; }
        public Category(ICollection<Comment> comments)
        {
            Comments = comments;
        }

        public Category()
        {
        }
        
        public static bool IsNullOrEmpty(Category category)
        {
            return category == null || category.Title == "";
        }

        public string Title { get; set; }


        public override string ToString()
        {
            return string.Format("ID: {0}, Is active: {1}< Title: {2}", Id,IsActive, Title);
        }
    }

}
