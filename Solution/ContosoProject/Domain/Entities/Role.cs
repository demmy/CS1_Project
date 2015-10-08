using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Role : Entity
    {
        public string Title { get; set; }
        public ICollection<Permission> Permissions { get; set; }

        public Role(ICollection<Permission> permissions)
        {
            Permissions = permissions;
        }
    }
}
