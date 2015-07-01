using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;
using Data.StoreData;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ContosoUI.UserSearchForm
{
    public class UserSearchPresenter: INotifyPropertyChanged
    {
        private readonly IUserSearchView view;
        private readonly UserSearchModel model;
        public event PropertyChangedEventHandler PropertyChanged;

        private string login;
        private string firstName;
        private string lastName;
        private BindingList<User> usersList;

        public UserSearchPresenter(IUserSearchView view, UserSearchModel model)
        {
            this.view = view;
            this.model = model;
            usersList = new BindingList<User>(Storage.Users);
        }

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

        public BindingList<User> Users
        {
            get { return usersList; }
            set
            {
                if (value != this.usersList)
                {
                    this.usersList = value;
                    //NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                Search();
            }
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
            var users = model.SearchUser(Login, FirstName, LastName);
            Users = new BindingList<User>((IList<User>)users);
        }

        public void Cancel()
        {
            Login = "";
            FirstName = "";
            LastName = "";
            Users = new BindingList<User>(Storage.Users);
        }
    }
}
