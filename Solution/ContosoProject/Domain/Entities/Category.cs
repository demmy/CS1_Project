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
        private string _title;
        private List<Comment> _comments;

        public Category(string title, IEnumerable<Comment> comments)
        {
            _title = title;
            _comments = comments;
        }
        
        string Title
        {
            // It maybe can be changed, think of it
            get
            {
                return _title;
            }
        }

        public IReadOnlyList<Comment> Comments
        {
            get 
            {
                return _comments;
            }
        }
    }
}
