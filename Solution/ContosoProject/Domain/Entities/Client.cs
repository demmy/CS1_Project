using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;
using Domain.Entities.Users;

namespace Domain.Entities
{
    public class Client : ExtendedEntity, ICommentable
    {
        public Location ClientLocation { get; set; }
        public Person Person { get; set; }
        private ICollection<string> _telephones;
        private ICollection<Comment> _comments = new List<Comment>();
        public Client(ICollection<string> telephones, ICollection<Comment> comments) : this()
        {
            _telephones = telephones;
            _comments.ToList().AddRange(comments);
        }

        public Client()
        {
            _comments.Add(new Comment()
            {
                Author = null,
                Date = DateTime.Now,
                EntityType = EntityType.Client,
                Id = -1,
                IsActive = true,
                Text = string.Format("Client has been added {0}", DateTime.Now.ToShortDateString())
            });
        }

        public IReadOnlyCollection<string> Telephones
        {
            get
            {
                return (IReadOnlyCollection<string>)_telephones;
            }
        }

        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)_comments; }
        }

        public override string ToString()
        {
            return Person.ToString();
        }
    }
}