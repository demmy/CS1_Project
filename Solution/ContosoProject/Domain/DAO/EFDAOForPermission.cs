using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForPermission<T> : EFDAOForRepository<T>, IPermissionRepository<T>
    {
        
    }
}
