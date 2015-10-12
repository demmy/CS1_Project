using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Save(T entity);
        void Delete(T entity);
        T Find(int id);

        ICollection<T> GetAll();
        ICollection<T> GetByIsActive(bool isActive);
        ICollection<T> GetByUser(User user);
        ICollection<T> GetByDate(DateTime date);
    }
}