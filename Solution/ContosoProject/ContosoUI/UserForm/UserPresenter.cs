using Data.DummyData;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.UserForm
{
    class UserPresenter : INotifyPropertyChanged
    {
        private readonly IUserView view;
        private readonly UserModel model;
        public event PropertyChangedEventHandler PropertyChanged;
        IUserRepository DefaultUser = new DummyDAOForUser(); 

        private string login;
        private string firstName;
        private string middleName;
        private string lastName;
        private Role role;
        private string roleTitle;
        private string password;
        private bool state;
        public List<Role> RoleList = new List<Role>(Storage.Roles);

        public UserPresenter(IUserView view, UserModel model)
        {
            this.view = view;
            this.model = model;
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

        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (value != this.middleName)
                {
                    this.middleName = value;
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

        public string Password
        {
            get { return password; }
            set
            {
                if (value != this.password)
                {
                    this.password = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Role Role
        {
            get { return role; }
            set
            {
                if (value != this.role)
                {
                    this.role = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string RoleTitle
        {
            get { return roleTitle; }
            set
            {
                if (value != this.roleTitle)
                {
                    this.roleTitle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool State
        {
            get { return state; }
            set
            {
                if (value != this.state)
                {
                    this.state = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void GetUser(int id)
        {
            var CurrentUser = DefaultUser.Find(id);

            Login = CurrentUser.Login;
            Password = CurrentUser.Password;
            FirstName = CurrentUser.Person.FirstName;
            MiddleName = CurrentUser.Person.MiddleName;
            LastName = CurrentUser.Person.LastName;
            Role = CurrentUser.Role;
            State = CurrentUser.IsActive;
        }

        public void Save()
        {         
            var user = new User();
            User existingUser = new User();
            var j = DefaultUser.GetBy(Login, FirstName, LastName);

            if (j.Count > 0)
                existingUser = j.First();

            user.Login = Login;
            user.Password = Password;
            user.Person = new Person();
            user.Person.FirstName = FirstName;
            user.Person.LastName = LastName;
            user.Person.MiddleName = MiddleName;

            user.Role = RoleList.Where(x => x.Title == roleTitle).First();

            user.IsActive = State;

            if (existingUser.Id == user.Id)
                model.Save(user);
            else
                model.Create(user);
        }

        public void SaveAndNew()
        {
            Save();
            Clear();
        }

        public void Clear()
        {
            Login = "";
            Password = "";
            FirstName = "";
            MiddleName = "";
            LastName = "";
            State = false;
            Role.Title = "";
        }
    }
}
