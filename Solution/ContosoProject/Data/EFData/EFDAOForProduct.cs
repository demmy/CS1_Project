using Domain.DAO;
using Domain.Entities;

namespace Data.EFData
{
    class EFDAOForProduct<T> : EFDAO<Product>, IProductRepository
    {
    }
}
