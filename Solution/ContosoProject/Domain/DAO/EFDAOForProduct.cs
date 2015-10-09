using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForProduct<T> : EFDAOForRepository<T>, IProductRepository<T>
    {
    }
}
