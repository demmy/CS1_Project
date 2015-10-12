using System;
using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.DummyData
{
    class DummyDAOForRole: DummyDAO<Role>, IRoleRepository
    {
        public DummyDAOForRole()
        {
            _collection = (IList<Role>) RolesCollection.Target;
        }
        public ICollection<Role> GetByTitle(string title)
        {
            if (_collection.Any(x => x.Title == title))
            {
                return _collection.Where(x => x.Title == title).ToList();
            }
            throw new Exception();
        }

        public ICollection<Role> GetByPermission(Permission permission)
        {
            if (_collection.Any(x =>x.Permissions.Any(perm=>perm == permission)))
            {
                return _collection.Where(x =>x.Permissions.Any(perm=>perm == permission)).ToList();
            }
            throw new Exception();
        }
    }
}
