using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;
using Data.DummyData;

namespace ContosoUI.UserSearchForm
{
    class UserSearchModel
    {
        public ICollection<User> SearchUser(string login, string firstName, string lastName)
        {
            DummyDAOForUser user = new DummyDAOForUser();

            user.GetByLogin(login);
            return user.GetByLogin(login);            
        }

    }
}
