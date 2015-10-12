using System.Collections.Generic;

namespace Domain.Entities
{
    public class Client : ExtendedEntity
    {
        Location ClientLocation { get; set; }
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
