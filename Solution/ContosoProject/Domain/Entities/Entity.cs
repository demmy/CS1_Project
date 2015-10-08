using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Entity
    {
        public bool IsActive { get; set; }

        protected Entity()
        {
        }

        public int Id { get; set; }
    }
}
