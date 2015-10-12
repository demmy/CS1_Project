using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;

namespace Data.EFData
{
    class EFDAOForUser : EFDAO<User>, IUserRepository
    {
        public ICollection<User> GetByLogin(string login)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<User> GetByRole(Role role)
        {
            throw new System.NotImplementedException();
        }
    }
}
