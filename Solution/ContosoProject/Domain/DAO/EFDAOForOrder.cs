using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAO
{
    class EFDAOForOrder<T> : IOrderRepository<T>
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> ReadAll()
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
