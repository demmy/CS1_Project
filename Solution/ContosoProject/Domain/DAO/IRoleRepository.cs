using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface IRoleRepository : IRepository<Role>
    {
        ICollection<Role> GetByTitle(string title);
        ICollection<Role> GetByPermission(Permission permission);
    }
}
