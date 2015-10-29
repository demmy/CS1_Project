using System.Collections.Generic;
using Domain.Entities.Comments;

namespace Domain.Entities.Clients
{
    public class Client : ExtendedEntity, ICommentable
    {       
        public Client(ICollection<Telephone> telephones, ICollection<Comment> comments)
        {
            Telephones = telephones;
            Comments = comments;
        }

        public Client()
        {
            
        }

        public Location ClientLocation { get; set; }
        public Person Person { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Telephone> Telephones { get; set; }
    }
}