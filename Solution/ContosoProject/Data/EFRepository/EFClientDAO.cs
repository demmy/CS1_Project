using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;

namespace Data.EFRepository
{
    public class EFClientDAO: EFExtendedDAO<Client>, IClientRepository
    {
        public ICollection<Client> FindBy(string firstName, string lastName, string city)
        {
            var result = dbContext.Clients.AsQueryable();

            if (!string.IsNullOrWhiteSpace(city))
                result = result.Where(client => client.ClientLocation.City == city);

            if (!string.IsNullOrWhiteSpace(firstName))
                result = result.Where(client => client.Person.FirstName == firstName);

            if (!string.IsNullOrWhiteSpace(lastName))
                result = result.Where(client => client.Person.LastName == lastName);

            return result.ToList();
        }
    }
}
