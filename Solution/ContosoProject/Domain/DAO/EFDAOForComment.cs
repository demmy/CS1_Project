using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForComment<T> : EFDAOForRepository<T>, ICommentRepository<T>
    {
    }
}
