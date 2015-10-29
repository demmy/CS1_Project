using System.Collections.Generic;
namespace Domain.Entities.Users
{
    public class Permission : Entity
    {
        public Permission()
        {
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
