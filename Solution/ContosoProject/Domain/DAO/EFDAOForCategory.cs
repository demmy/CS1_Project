using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForCategory<T> : EFDAOForRepository<T>, ICategoryRepository<T>
    {
        
    }
}
