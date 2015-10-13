using System.Collections.Generic;
using Domain.Entities.Comments;

namespace Domain.Entities
{
    public class Client : ExtendedEntity
    {
        public Location ClientLocation { get; set; }
        public Person Person { get; set; }
        private ICollection<string> _telephones;

        public Client(ICollection<string> telephones)
        {
            _telephones = telephones;
        }
        public IReadOnlyCollection<string> Telephones
        {
            get
            {
                return (IReadOnlyCollection<string>)_telephones;
            }
        }

    }
}
