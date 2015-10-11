using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Location
    {
        public string City { get; set; }
        public string Adress { get; set; }

        public Location()
        {

        }

        protected bool Equals(Location other)
        {
            return string.Equals(City, other.City) && string.Equals(Adress, other.Adress);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Location)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return ((City != null ? City.GetHashCode() : 0) * 397) ^ (Adress != null ? Adress.GetHashCode() : 0);
            }
        }
    }

}
