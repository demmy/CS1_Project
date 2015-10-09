using System.Collections.Generic;

namespace Data.Repository
{
    public interface IRepository<T>
    {
        void Create(T entity);
        ICollection<T> ReadAll();
        T Find(int id);
        void Save(T entity);
        void Delete(T entity);
    }
}
