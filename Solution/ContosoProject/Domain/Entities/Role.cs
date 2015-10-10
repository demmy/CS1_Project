using System.Collections.Generic;

namespace Domain.Entities
{
    public class Role : Entity
    {
        public Role(ICollection<Permission> permissions)
        {
            Permissions = permissions;
        }
        public string Title { get; set; }
        public ICollection<Permission> Permissions { get; set; }
    }
}
