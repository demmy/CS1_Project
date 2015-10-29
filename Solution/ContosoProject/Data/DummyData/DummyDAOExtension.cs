using System;
using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities;

namespace Data.DummyData
{
    public class DummyDAOExtension<T> : DummyDAO<T>, IRepositoryExtension<T> where T : ExtendedEntity, new()
    {
        public ICollection<T> GetByDate(DateTime date)
        {
<<<<<<< HEAD
            if (Collection.Any(x => String.Equals(x.Date.ToShortDateString(), date.ToShortDateString())))
=======
            if (_collection.Any(x => x.Date.ToShortDateString() == date.ToShortDateString()))
>>>>>>> 10a7b2ff162e1fcfa5eaa24a4d109dc235eb20a5
            {
                return Collection.Where(x => x.Date.ToShortDateString() == date.ToShortDateString()).ToList();
            }
            throw new Exception();
        }
    }
}