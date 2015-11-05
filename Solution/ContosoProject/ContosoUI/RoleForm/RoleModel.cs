using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Data.EFRepository;
using DevExpress.XtraRichEdit.Commands;
using Domain.DAO;
using Domain.Entities.Users;

namespace ContosoUI.RoleForm
{
    internal class RoleModel:Model
    {

        public readonly IRoleRepository RoleRepository;
        public readonly IPermissionRepository PermissionRepository;

        public RoleModel()
            :base()
        {
            RoleRepository = Facade.RoleRepository;
            PermissionRepository = Facade.PermissionRepository;
        }

        public void Save(Role currentRole)
        {
            RoleRepository.Save(currentRole);
        }

        public void Create(Role currentRole)
        {
            RoleRepository.Create(currentRole);
        }
        
        public Role Find(int id)
        {
            return RoleRepository.Find(id);
        }
    }
}