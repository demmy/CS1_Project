using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Factories
{
    public class ClientRepositoryFactory: IRepositoryFactory<Domain.Entities.Clients.Client>
    {
        public Domain.DAO.IRepository<Domain.Entities.Clients.Client> GetEFRepository()
        {
            return new EFRepository.EFRoleDAO();
        }

        public Domain.DAO.IRepository<Domain.Entities.Clients.Client> GetDummyRepository()
        {
            return new DummyData.DummyDAOForRole();
        }
    }
}
