using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Factories
{
    public class OrderRepositoryFactory: IRepositoryFactory<Domain.Entities.Orders.Order>
    {
        public Domain.DAO.IRepository<Domain.Entities.Orders.Order> GetEFRepository()
        {
            return new EFRepository.EFOrderDAO();
        }

        public Domain.DAO.IRepository<Domain.Entities.Orders.Order> GetDummyRepository()
        {
            return new DummyData.DummyDAOForOrder();
        }
    }
}
