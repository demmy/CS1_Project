using System.Collections.Generic;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface IPermissionRepository
    {
        ICollection<Permission> GetByTitle(string title);
    }
}
