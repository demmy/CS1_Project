using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client : ExtendedEntity
    {
        Location ClientLocation { get; set; }
        private ICollection<string> _telephones;


        public Client(ICollection<string> telephones, DateTime date, bool isActive)
            : base(date, isActive)
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
