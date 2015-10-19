using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface IUserRepository : IRepositoryExtension<User>
    {
        ICollection<User> GetByLogin(string login);
        ICollection<User> GetByRole(Role role);
    }
}
