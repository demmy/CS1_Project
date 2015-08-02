using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.DummyData
{
    public class DummyDAOForUser : DummyDAO<User>, IUserRepository
    {
        public ICollection<User> GetByLogin(string login)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<User> GetByRole(Role role)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<User> GetByName(string fn, string ln)
        {
            throw new System.NotImplementedException();
        }
    }
}
