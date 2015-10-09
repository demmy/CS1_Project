using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForEntity<T> : EFDAOForRepository<T>, IEntityRepository<T>
    {
    }
}
