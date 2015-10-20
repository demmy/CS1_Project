using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;
using Data.DummyData;
using Domain.Entities;

namespace ContosoUI.UserSearchForm
{
    class UserSearchModel
    {
        public ICollection<User> SearchUser(string login, string firstName, string lastName)
        {
            DummyDAOForUser user = new DummyDAOForUser();

            return user.GetBy(login, new Person{FirstName = firstName, LastName = lastName});            
        }

    }
}
