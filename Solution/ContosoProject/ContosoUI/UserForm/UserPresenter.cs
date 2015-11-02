using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Data.DummyData;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Users;

namespace ContosoUI.UserForm
{
    internal class UserPresenter : Presenter, IViewPresenter
    {
        private readonly IUserView _view;
        private readonly UserModel _model;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;

        public UserPresenter(IUserView view, UserModel model)
        {
            _roleRepository = model.RoleRepository;
            _userRepository = model.UserRepository;
            _view = view;
            _model = model;
            var roles = _roleRepository.GetAll();
            RoleList = new List<Domain.Entities.Users.Role>(roles);            
        }

        User _user = new User();
        private bool _state;
        private string _login = string.Empty;
        private string _firstName = string.Empty;
        private string _middleName = string.Empty;
        private string _lastName = string.Empty;
        private string _password = string.Empty;
        public Role Role = new Role();
        public List<Role> RoleList;

        BindingList<Permission> _permissions = new BindingList<Permission>();
        BindingList<Comment> _comments = new BindingList<Comment>();

        #region Properties
        public string Login
        {
            get { return _login; }
            set
            {
                if (value != _login)
                {
                    _login = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value != _firstName)
                {
                    _firstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value != _middleName)
                {
                    _middleName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value != _lastName)
                {
                    _lastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public BindingList<Permission> Permissions
        {
            get { return _permissions; }
            set
            {
                if (!value.SequenceEqual(_permissions))
                {
                    _permissions = value;
                    NotifyPropertyChanged();
                }
                
            }
        }
        public BindingList<Comment> Comments
        {
            get { return _comments; }
            set
            {
                if (!value.SequenceEqual(_comments))
                {
                    _comments = value;
                    NotifyPropertyChanged();
                }
            }
        }
         public int RoleID
        {
            get { return (Role == null) ? 0 : Role.Id; }
            set
            {
                Role = RoleList.FirstOrDefault(x => x.Id == value);
                if (Role != null) Permissions = new BindingList<Permission>(Role.Permissions.ToList());
                NotifyPropertyChanged();
            }
        }
        public bool State
        {
            get { return _state; }
            set
            {
                if (value != _state)
                {
                    _state = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        public void GetUser(int id)
        {
            _user  = _userRepository.Find(id);

            Login = _user.Login;
            Password = _user.Password;
            FirstName = _user.Person.FirstName;
            MiddleName = _user.Person.MiddleName;
            LastName = _user.Person.LastName;
            RoleID = _user.Role.Id;
            Permissions = new BindingList<Permission>(_user.Role.Permissions.ToList());
            State = _user.IsActive;
            Comments = new BindingList<Comment>(_user.Comments.ToList());
        }

        public void Save()
        {
            User userToSave = new User(_comments)
            {
                Id = _user.Id,
                IsActive = _state,
                Login = _login,
                Password = _password,
                Person = new Person() {FirstName = _firstName, MiddleName = _middleName, LastName = _lastName},
                Role = Role
            };

            if (userToSave.Id != 0)
            {
                if (!_model.Find(userToSave.Id).Equals(userToSave))
                {
                    _model.Save(userToSave);
                    _user = userToSave;
                }
            }
            else
            {
                if (_model.Find(userToSave.Id) == null)
                {
                    _model.Create(userToSave);
                    _user = userToSave;
                }
            }
        }

        public void SaveAndNew()
        {
            Save();
            New();
        }

        public void New()
        {
            Login = "";
            Password = "";
            FirstName = "";
            MiddleName = "";
            LastName = "";
            State = true;
            Role = new Role( );
            Permissions = new BindingList<Permission>();
            Comments = new BindingList<Comment>();
        }
    }
}
