using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace ContosoUI.UserSearchForm
{
    class UserModel
    {
        Data.DummyData.DummyDAOForUser user = new Data.DummyData.DummyDAOForUser();

        public void AddUser()
        {
            ContosoUI.ClientForm addUserForm = new ContosoUI.ClientForm(null);
            addUserForm.Show();
        }

        public void EditUser (string login, string firstName, string lastName)
        {
            
        }

        public ICollection<User> SearchUser(string login, string firstName, string lastName)
        {
            user.GetByLogin(login);
            return user.GetByLogin(login);            
        }

        public ICollection<User> Cancel()
        {
            return SearchUser(null, null, null);
        }


    }
}
