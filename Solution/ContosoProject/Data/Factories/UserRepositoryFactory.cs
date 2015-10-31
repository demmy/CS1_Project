using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Factories
{
    public class UserRepositoryFactory: IRepositoryFactory<Domain.Entities.Users.User>
    {
        public Domain.DAO.IRepository<Domain.Entities.Users.User> GetEFRepository()
        {
            return new EFRepository.EFUserDAO();
        }

        public Domain.DAO.IRepository<Domain.Entities.Users.User> GetDummyRepository()
        {
            return new DummyData.DummyDAOForUser();
        }
    }
}
