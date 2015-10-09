using System;
using System.Collections.Generic;
using Data.Repository;

namespace Domain.DAO
{
    class EFDAOForRepository<T> : IRepository<T>
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
