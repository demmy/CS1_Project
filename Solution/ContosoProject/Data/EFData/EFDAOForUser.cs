using System.Runtime.CompilerServices;
using Domain.DAO;
using Domain.Entities;

namespace Data.EFData
{
    class EFDAOForUser : EFDAO<User>, IUserRepository
    {
    }
}
