using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAO
{
    interface IExtendedEntityRepository<T> : IRepository<T> 
    {
    }
}
