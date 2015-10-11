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


        protected bool Equals(Client other)
        {
            return Equals(_telephones, other._telephones) && Equals(ClientLocation, other.ClientLocation);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Client)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return ((_telephones != null ? _telephones.GetHashCode() : 0) * 397) ^ (ClientLocation != null ? ClientLocation.GetHashCode() : 0);
            }
        }
    }

}
