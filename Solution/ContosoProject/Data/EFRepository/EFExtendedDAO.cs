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
        public EFExtendedDAO(ProjectContext context)
            : base(context)
        {

        }
        /// <summary>
        /// Gets the enities that where added/edited on the specified date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public ICollection<T> GetByDate(DateTime date)
        {
            return dbContext.Set<T>()
                .Where(x => x.Date.ToShortDateString() == date.ToShortDateString())
                .ToList();
        }
    }
}
