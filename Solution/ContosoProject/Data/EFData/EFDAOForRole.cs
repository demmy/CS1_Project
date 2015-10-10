using Domain.DAO;
using Domain.Entities;

namespace Data.EFData
{
    class EFDAOForRole<T> : EFDAO<Role>, IRoleRepository
    {
    }
}
