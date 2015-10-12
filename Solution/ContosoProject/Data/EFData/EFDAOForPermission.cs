using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;

namespace Data.EFData
{
    class EFDAOForPermission<T> : EFDAO<Permission>, IPermissionRepository
    {
        public ICollection<Permission> GetByTitle(string title)
        {
            throw new System.NotImplementedException();
        }
    }
}
