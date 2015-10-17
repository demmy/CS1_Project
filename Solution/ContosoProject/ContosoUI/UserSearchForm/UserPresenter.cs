using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace ContosoUI.UserSearchForm
{
    class UserPresenter
    {
        private readonly IUserView view;
        private readonly UserModel model;

        public UserPresenter (IUserView view, UserModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void AddUser()
        {
            model.AddUser();
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
            var users = model.Cancel();
            view.UserGrid = users;
        }
    }
}
