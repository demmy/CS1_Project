using System.Collections.Generic;

namespace Domain.Entities.Users
{
    public class Role : Entity
    {
        public Role(ICollection<Permission> permissions)
        {
            Permissions = permissions;
        }

        public Role()
        {
        }

        public string Title { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
