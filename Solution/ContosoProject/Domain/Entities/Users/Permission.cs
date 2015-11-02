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
        public override string ToString()
        {
            return Description != string.Empty ? string.Format("{0}: {1}", Title, Description) : Title;
        }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
