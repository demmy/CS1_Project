using System;
using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.DummyData
{
    public class DummyDAO<T> : IRepository<T>
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

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetByIsActive(bool isActive)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetByUser(User user)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetByDate(DateTime date)
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
