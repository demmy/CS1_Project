using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Permission : Entity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }

        public Permission(int id, bool isActive, string description, string title) : base(id, isActive)
        {
            Description = description;
            Title = title;
        }
    }
}
