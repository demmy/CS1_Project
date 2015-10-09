using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForClient<T> : EFDAOForRepository<T>, IClientRepository<T>
    {
    }
}
