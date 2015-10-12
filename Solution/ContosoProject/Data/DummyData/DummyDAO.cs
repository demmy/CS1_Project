using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;

namespace Data.DummyData
{
    class DummyDAO<T> : IRepository<T> where T : Entity, new()
    {
        protected IList<T> _collection = new List<T>(); 
        public void Create(T entity)
        {
            if(!(_collection.All(x => x == entity)))
            _collection.Add(new T());
        }

        public T Find(int id)
        {
            return _collection.First(x => x.Id==id);
        }

        public ICollection<T> GetAll()
        {
            return _collection;
        }

        public ICollection<T> GetByIsActive(bool isActive)
        {
            return (ICollection<T>) _collection.Select(x => x.IsActive == isActive).ToList();
        }

        public void Save(T entity)
        {
            T oldEntity = _collection.First(x => x.Id == entity.Id);
            oldEntity.Id = entity.Id;
            oldEntity.IsActive = entity.IsActive;
        }

        public void Delete(T entity)
        {
            _collection.Remove(entity);
        }
        public void Delete(int id)
        {
           _collection.RemoveAt(id);
        }
    }
}
