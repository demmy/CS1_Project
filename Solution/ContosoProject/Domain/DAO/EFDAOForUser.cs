using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForUser<T> : EFDAOForRepository<T>, IUserRepository<T>
    {
    }
}
