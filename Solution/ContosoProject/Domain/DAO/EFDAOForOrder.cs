using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForOrder<T> : EFDAOForRepository<T>, IOrderRepository<T>
    {
        
    }
}
