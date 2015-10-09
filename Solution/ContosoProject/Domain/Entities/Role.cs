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
        public List<Permission> Permissions { get; set; }
        
        public Role(List<Permission> permissions, bool isActive) : base(isActive)
        {
            Permissions = permissions;
        }
    }
}
