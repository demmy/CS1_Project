using Domain.Entities.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// The entity that describes the type of product
    /// </summary>
    public class Category: ExtendedEntity, ICommentable
    {
        private ICollection<Comment> _comments;

        public Category(ICollection<Comment> comments)
        {
            _comments = comments;
        }
        
        string Title { get; set; }

        public IReadOnlyCollection<Comment> Comments
        {
            get 
            {
                return (IReadOnlyCollection<Comment>)_comments;
            }
        }
    }
}
