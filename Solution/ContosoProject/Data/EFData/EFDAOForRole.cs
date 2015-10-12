using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.EFData
{
    class EFDAOForRole<T> : EFDAO<Role>, IRoleRepository
    {
        public ICollection<Role> GetByTitle(string title)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Role> GetByPermission(Permission permission)
        {
            throw new System.NotImplementedException();
        }
    }
}
