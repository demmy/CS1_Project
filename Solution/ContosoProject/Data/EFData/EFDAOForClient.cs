using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities;

namespace Data.EFData
{
    class EFDAOForClient : EFDAO<Client>, IClientRepository
    {
    }
}
