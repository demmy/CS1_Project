using System;
using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.DummyData
{
    class DummyDAOForPermission: DummyDAO<Permission>, IPermissionRepository
    {
        public DummyDAOForPermission()
        {
            _collection = (IList<Permission>) PermissionsCollection.Target;
        }
        public ICollection<Permission> GetByTitle(string title)
        {
            if (_collection.Any(x => x.Title == title))
            {
                return _collection.Where(x => x.Title == title).ToList();
            }
            throw new Exception();
        }
    }
}
