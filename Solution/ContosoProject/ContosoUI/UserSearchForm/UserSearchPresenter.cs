using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace ContosoUI.UserSearchForm
{
    class UserSearchPresenter
    {
        private readonly IUserSearchView view;
        private readonly UserSearchModel model;

        public UserSearchPresenter(IUserSearchView view, UserSearchModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void AddUser()
        {
            UserForm.UserForm addUserForm = new UserForm.UserForm();
            addUserForm.Show();
        }

        public void EditUser(int id)
        {
            UserForm.UserForm editUserForm = new UserForm.UserForm(id);           
            editUserForm.Show();
        }

        public void Search()
        {
            var users = model.SearchUser(view.Login, view.FirstName, view.LastName);
            view.UserGrid = users;
        }

        public void Cancel()
        {
            view.Login = null;
            view.FirstName = null;
            view.LastName = null;
            view.UserGrid.Clear(); 
        }
    }
}
