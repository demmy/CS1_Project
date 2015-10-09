using System.Collections.Generic;
using Domain.Entities;

namespace Domain.DAO
{
    interface IRepository<T>
    {
        void Create(T entity);
        ICollection<T> ReadAll();
        T Find(int id);
        void Save(T entity);
        void Delete(T entity);
    }
}
