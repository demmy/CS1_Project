using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Entity
    {
        public int ID { get; private set; }
        public bool IsActive { get; set; }

        public Entity(int id, bool isActive)
        {
            ID = id;
            IsActive = isActive;
        }
    }
}
