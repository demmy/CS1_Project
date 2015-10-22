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

namespace ContosoUI.UserSearchForm
{
    public class UserSearchPresenter: INotifyPropertyChanged
    {
        private readonly IUserSearchView view;
        private readonly IUserRepository model = new DummyDAOForUser();
        public event PropertyChangedEventHandler PropertyChanged =delegate(object sender, PropertyChangedEventArgs args) {  };

        private string login = string.Empty;
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private BindingList<User> usersList;

        public UserSearchPresenter(IUserSearchView view)
        {
            this.view = view;
            usersList = new BindingList<User>(model.GetAll().ToList());
        }

        public string Login 
        {
            get { return login; }
            set
            {
                if (value != this.login)
                {
                    this.login = value;
                    NotifyPropertyChanged("Login");
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
                    NotifyPropertyChanged("FirstName");
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
                    NotifyPropertyChanged("LastName");
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
                    NotifyPropertyChanged("Users");
                }
            }
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void AddUser()
        {
            NicksForms.User_form.UserForm addUserForm = new NicksForms.User_form.UserForm();
            addUserForm.Show();
        }

        public void EditUser(int id)
        {
            NicksForms.User_form.UserForm editUserForm = new NicksForms.User_form.UserForm(id);           
            editUserForm.Show();
        }

        public void Search()
        {
            var users = model.GetBy(Login, FirstName, LastName).ToList();
            Users = new BindingList<User>(users);
            NotifyPropertyChanged("Users");
        }

        public void Clear()
        {
            Login = "";
            FirstName = "";
            LastName = "";
            Users = new BindingList<User>(Storage.Users);
        }
    }
}
