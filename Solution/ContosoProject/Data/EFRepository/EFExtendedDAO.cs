using System;
using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities;

namespace Data.EFRepository
{
    public class EFExtendedDAO<T>: EFBaseDao<T>, IRepositoryExtension<T>
        where T : ExtendedEntity, new()
    {
        public ICollection<T> GetByDate(DateTime date)
        {
            return dbContext.Set<T>()
                .Where(x => x.Date.ToShortDateString() == date.ToShortDateString())
                .ToList();
        }
    }
}
