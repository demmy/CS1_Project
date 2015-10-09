using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForRole<T> : EFDAOForRepository<T>, IRoleRepository<T>
    {
    }
}
