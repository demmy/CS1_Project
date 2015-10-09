using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Permission : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Permission(bool isActive) : base(isActive)
        {
        }
    }
}
