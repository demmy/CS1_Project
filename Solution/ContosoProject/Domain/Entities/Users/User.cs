using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;

namespace Domain.Entities.Users
{
    public class User : ExtendedEntity, ICommentable
    {
        private ICollection<Comment> _comments = new List<Comment>()
        {
            new Comment()
            {
                Author = null,
                Date = DateTime.Now,
                EntityType = EntityType.User,
                Text = string.Format("User has been added ")
            }
        };

        public User(ICollection<Comment> comments)
        {
            _comments = comments;
        }

        public User()
        {
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public Person Person { get; set; }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)_comments; }
        }

        public override string ToString()
        {
            return string.Format("{0}", Login);
        }
    }
}