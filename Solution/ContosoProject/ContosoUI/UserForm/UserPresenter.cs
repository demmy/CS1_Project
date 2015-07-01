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
    class UserPresenter : Presenter, IViewPresenter
    {
        private readonly IUserView view;
        private readonly UserModel model;

        IUserRepository DefaultUser = new DummyDAOForUser(); 

        public UserPresenter(IUserView view, UserModel model)
        {
            this.view = view;
            this.model = model;
        }
                
        private string login;
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

        private string firstName;
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

        private string middleName;
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

        private string lastName;
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

        private string password;
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

        public Role Role = new Role();
        public List<Role> RoleList = new List<Role>(Storage.Roles);
        public int RoleID
        {
            get { return (Role == null) ? 0 : Role.Id; }
            set
            {
                this.Role = RoleList.Where(x => x.Id == value).FirstOrDefault();
                NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
                }
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
