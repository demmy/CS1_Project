using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.DummyData
{
    class DummyDAOForUser : DummyDAOExtension<User>, IUserRepository
    {
        public DummyDAOForUser()
        {
            _collection = Storage.Users;
        }
        public ICollection<User> GetByLogin(string login)
        {
            if (_collection.Any(x => x.Login == login))
            {
                return _collection.Where(x=>x.Login==login).ToList();
            }
            throw new Exception();
        }

        public ICollection<User> GetByRole(Role role)
        {
            if (_collection.Any(x => x.Role == role))
            {
                return _collection.Where(x => x.Role == role).ToList();
            }
            throw new Exception();
        }
    }
}
