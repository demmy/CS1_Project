using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface IPermissionRepository : IRepository<Permission>
    {
        ICollection<Permission> GetByTitle(string title);
    }
}
