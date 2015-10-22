using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Data.DummyData;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;

namespace ContosoUI.NicksForms.User_form
{
    class UserPresenter : INotifyPropertyChanged
    {
        private readonly IUserView view;
        private readonly UserModel model;
        public event PropertyChangedEventHandler PropertyChanged = delegate(object sender, PropertyChangedEventArgs args) {  };

        IUserRepository DefaultUser = new DummyDAOForUser(); 

        public UserPresenter(IUserView view, UserModel model)
        {
            this.view = view;
            this.model = model;
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
                    NotifyPropertyChanged("Login");
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
                    NotifyPropertyChanged("FirstName");
                }
            }
        }

        private string middleName = string.Empty;
        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (value != this.middleName)
                {
                    this.middleName = value;
                    NotifyPropertyChanged("MiddleName");
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
                    NotifyPropertyChanged("LastName");
                }
            }
        }

        private string password = string.Empty;
        public string Password
        {
            get { return password; }
            set
            {
                if (value != this.password)
                {
                    this.password = value;
                    NotifyPropertyChanged("Password");
                }
            }
        }

        public Role Role = new Role();
        public List<Role> RoleList = new List<Role>(Storage.Roles);
        public int RoleID
        {
            get { return (Role == null) ? 0 : Role.Id; }
            set
            {
                Role = RoleList.FirstOrDefault(x => x.Id == value);
                NotifyPropertyChanged("RoleID");
            }
        }

        private bool state;
        public bool State
        {
            get { return state; }
            set
            {
                if (value != this.state)
                {
                    this.state = value;
                    NotifyPropertyChanged("State");
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

        public void GetUser(int id)
        {
            var CurrentUser = DefaultUser.Find(id);

            Login = CurrentUser.Login;
            Password = CurrentUser.Password;
            FirstName = CurrentUser.Person.FirstName;
            MiddleName = CurrentUser.Person.MiddleName;
            LastName = CurrentUser.Person.LastName;
            RoleID = CurrentUser.Role.Id;
            State = CurrentUser.IsActive;
        }

        public void Save()
        {         
            User user = new User();
            var existingUser = DefaultUser.GetBy(Login, FirstName, LastName);

            user.Login = Login;
            user.Password = Password;
            user.Person = new Person();
            user.Person.FirstName = FirstName;
            user.Person.LastName = LastName;
            user.Person.MiddleName = MiddleName;
            user.Role = Role;
            user.IsActive = State;

            if (existingUser.Count > 0)
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
            Role = null;
        }
    }
}
