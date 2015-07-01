using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;
using Data.DummyData;
using Domain.DAO;

namespace ContosoUI.UserSearchForm
{
    public class UserSearchModel
    {
        IUserRepository user = new DummyDAOForUser();

        public ICollection<User> SearchUser(string login, string firstName, string lastName)
        {
            return user.GetBy(login, firstName, lastName);            
        }

    }
}
