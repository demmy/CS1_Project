using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Domain.Entities
{
    class ExtendedEntity : Entity
    {
        public User User { get; private set; }
        public DateTime Date { get; private set; }
    
        public ExtendedEntity(int id, bool isActive, DateTime date, User user) : base(id, isActive)
        {
            Date = DateTime.Now;
            User = user;
        }

     } 
}
