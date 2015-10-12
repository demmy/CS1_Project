using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.DummyData
{
    class DummyDAOForPermission: DummyDAO<Permission>, IPermissionRepository
    {
        public ICollection<Permission> GetByTitle(string title)
        {
            throw new System.NotImplementedException();
        }
    }
}
