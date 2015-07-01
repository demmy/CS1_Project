using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities.Users;
using Domain.Entities;

namespace Data.DummyData
{
    public class DummyDAOForUser : DummyDAOExtension<User>, IUserRepository
    {
        public DummyDAOForUser()
        {
            _collection = Storage.Users;
        }

        public ICollection<User> GetBy(string login, string firstName, string lastName)
        {
            var result = _collection.AsQueryable();
            if (!string.IsNullOrWhiteSpace(login))
            {
                result = result.Where(x => x.Login == login);
            }
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                result = result.Where(x => x.Person.FirstName == firstName);
            }
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                result = result.Where(x => x.Person.LastName == lastName);
            }
            return result.ToList();
        }
    }
}