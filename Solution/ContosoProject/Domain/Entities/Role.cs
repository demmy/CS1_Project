using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Role : Entity
    {
        public string Title { get; private set; }
        public List<Permission> Permissions { get; private set; }
        
        public Role(int id, bool isActive, List<Permission> permissions, string title) : base(id, isActive)
        {
            Permissions = permissions;
            Title = title;
        }
    }
}
