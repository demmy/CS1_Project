using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Factories
{
    public class RoleRepositoryFactory: IRepositoryFactory<Domain.Entities.Users.Role>
    {
        public Domain.DAO.IRepository<Domain.Entities.Users.Role> GetEFRepository(Data.EFRepository.ProjectContext context)
        {
            return new EFRepository.EFRoleDAO(context);
        }

        public Domain.DAO.IRepository<Domain.Entities.Users.Role> GetDummyRepository()
        {
            return new DummyData.DummyDAOForRole();
        }
    }
}
