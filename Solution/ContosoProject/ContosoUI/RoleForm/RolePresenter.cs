using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using Domain.Entities.Users;

namespace ContosoUI.RoleForm
{
    internal class RolePresenter : Presenter
    {
        private RoleModel _model;
        private IRoleView _view;
        private BindingList<Permission> _avalaiblePermissions = new BindingList<Permission>();
        private BindingList<Role> _avalaibleRoles = new BindingList<Role>();

        private Role _role;
        private BindingList<Permission> _currentRolePermissions = new BindingList<Permission>();
        private List<KeyValuePair<Permission, bool>> _checkedPermissions = new List<KeyValuePair<Permission, bool>>();

        Dictionary<Role, List<Permission>> _changedRoles = new Dictionary<Role, List<Permission>>();

        public RolePresenter(IRoleView view, RoleModel model)
        {
            _view = view;
            _model = model;
            InitializeFields();
        }

        private void InitializeFields()
        {
            _avalaibleRoles = new BindingList<Role>(_model.RoleRepository.GetAll().ToList());
            _avalaiblePermissions = new BindingList<Permission>(_model.PermissionRepository.GetAll().ToList());
        }

        public void UsePermissionWithRoleID(int id)
        {
            if (id != 0)
            {
                _role = _avalaibleRoles.First(x => x.Id == id);
                _currentRolePermissions = new BindingList<Permission>(_role.Permissions.ToList());
                _checkedPermissions.Clear();
                foreach (var permission in _avalaiblePermissions)
                {   
                    _checkedPermissions.Add(new KeyValuePair<Permission, bool>(permission, _currentRolePermissions.Any(x=>x.Title==permission.Title)));
                }
             }
        }

        public void ChangedRolePermission(Permission permission, bool state)
        {
             if (!_changedRoles.Any(x => x.Key.Equals(_role)))
            {
                _changedRoles.Add(_role, _role.Permissions.ToList());
            }

            if (_changedRoles[_role].Any(x=>x.Title==permission.Title))
            {
                _changedRoles[_role].Remove(_changedRoles[_role].First(x => x.Title == permission.Title));
            }
            else
            {
                _changedRoles[_role].Add(permission);
            }
        
       }

        public Role Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public BindingList<Permission> CurrentRolePermissions
        {
            get { return _currentRolePermissions; }
            set { _currentRolePermissions = value; }
        }

        public List<KeyValuePair<Permission, bool>> CheckedPermissions
        {
            get { return _checkedPermissions; }
            set { _checkedPermissions = value; }
        }

        public BindingList<Role> AvalaibleRoles
        {
            get { return _avalaibleRoles; }
            set
            {
                if (!value.SequenceEqual(_avalaibleRoles))
                {
                    _avalaibleRoles = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public BindingList<Permission> AvalaiblePermissions
        {
            get { return _avalaiblePermissions; }
        }

        public void Save()
        {
            foreach (var kvp in _changedRoles)
            {
                kvp.Key.Permissions = kvp.Value;
                _model.RoleRepository.Save(kvp.Key);
            }
            _avalaibleRoles.ForEach(x=>_model.Save(x));
        }

        public void SaveAndNew()
        {
            Save();
        }

        public void AddNewRole()
        {
            _model.RoleRepository.Create(new Role(new List<Permission>()) {Title = string.Empty});
            _avalaibleRoles = new BindingList<Role>(_model.RoleRepository.GetAll().ToList());
            NotifyPropertyChanged("AvalaibleRoles");
        }
    }
}
