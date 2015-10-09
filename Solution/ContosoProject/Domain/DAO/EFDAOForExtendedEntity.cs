using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForExtendedEntity<T> : EFDAOForRepository<T>, IExtendedEntityRepository<T>
    {
    }
}
