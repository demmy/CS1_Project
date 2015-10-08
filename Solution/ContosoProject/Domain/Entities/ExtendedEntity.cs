using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Domain.Entities
{
    public abstract class ExtendedEntity : Entity
    {
        protected ExtendedEntity()
        {
        }

        public User User { get; set; }

        public DateTime Date { get; set; }

     } 
}
