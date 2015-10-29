using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;
using Data.StoreData;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Data.DummyData;
using Domain.DAO;
using ContosoUI.Annotations;

namespace ContosoUI.UserSearchForm
{
    public class UserSearchPresenter: Presenter, ISearchPresenter
    {
        private readonly IUserSearchView view;
        private readonly IUserRepository model = new DummyDAOForUser();

        public UserSearchPresenter(IUserSearchView view)
        {
            this.view = view;
        }

        private string login = string.Empty;
        public string Login 
        {
            get { return login; }
            set
            {
                if (value != this.login)
                {
                    this.login = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string firstName = string.Empty;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != this.firstName)
                {
                    this.firstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string lastName = string.Empty;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value != this.lastName)
                {
                    this.lastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private BindingList<User> usersList = new BindingList<User>();
        public BindingList<User> Users
        {
            get { return usersList; }
            set
            {
                if (value != this.usersList)
                {
                    this.usersList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void Edit(int id)
        {
            UserForm.UserForm editUserForm = new UserForm.UserForm(id);
            editUserForm.MdiParent = Program.MainForm;
            editUserForm.Show();
        }

        public void Search()
        {
            List<User> users; 
            if (Login != null && FirstName != null && LastName != null)
                users = model.GetBy(Login, FirstName, LastName).ToList();
            else
                users = model.GetAll().ToList();

            Users = new BindingList<User>(users);
        }

        public void Clear()
        {
            Login = null;
            FirstName = null;
            LastName = null;
            Users.Clear();
        }
    }
}
