using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : ExtendedEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(DateTime date, bool isActive) : base(date, isActive)
        {
            
        }

    }
}
