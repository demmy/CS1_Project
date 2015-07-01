using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;

namespace Domain.Entities.Users
{
    public class User : ExtendedEntity, ICommentable
    {
        private ICollection<Comment> _comments = new List<Comment>(); 
        public User(ICollection<Comment> comments) : this()
        {
            _comments.ToList().AddRange(comments);
        }

        public User()
        {
            _comments.Add(new Comment()
            {
                Author = null,
                Date = DateTime.Now,
                EntityType = EntityType.User,
                Id = -1,
                IsActive = true,
                Text = string.Format("User has been added ")
            });
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