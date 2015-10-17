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
        private readonly UserForm.IUserView viewUserForm;

        public UserSearchPresenter(IUserSearchView view, UserSearchModel model, UserForm.IUserView viewUserForm)
        {
            this.view = view;
            this.model = model;
            this.viewUserForm = viewUserForm;
        }

        public void AddUser()
        {
            UserForm.UserForm addUserForm = new UserForm.UserForm();
            addUserForm.Show();
        }

        public void EditUser(int id)
        {
            Data.DummyData.DummyDAO<User> DefaultUser = new Data.DummyData.DummyDAO<User>();
            var CurrentUser = DefaultUser.Find(id);

            viewUserForm.Login = CurrentUser.Login;
            viewUserForm.Password = CurrentUser.Password;
            viewUserForm.FirstName = CurrentUser.Person.FirstName;
            viewUserForm.MiddleName = CurrentUser.Person.MiddleName;
            viewUserForm.LastName = CurrentUser.Person.LastName;
            viewUserForm.Role = CurrentUser.Role.Title;
            viewUserForm.Active = CurrentUser.IsActive;
            viewUserForm.Comments = (ICollection<Domain.Entities.Comments.Comment>)CurrentUser.Comments;

            UserForm.UserForm addUserForm = new UserForm.UserForm();
            addUserForm.Show();
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
