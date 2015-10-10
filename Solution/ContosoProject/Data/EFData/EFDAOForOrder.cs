using Domain.DAO;
using Domain.Entities;

namespace Data.EFData
{
    class EFDAOForOrder<T> : EFDAO<Order>, IOrderRepository
    {
        
    }
}
