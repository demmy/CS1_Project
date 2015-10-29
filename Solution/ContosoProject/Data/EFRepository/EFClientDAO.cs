using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Clients;

namespace Data.EFRepository
{
    public class EFClientDAO: EFExtendedDAO<Client>, IClientRepository
    {
        //TODO: Merge with last working state
        public ICollection<Client> GetBy(Person person, string city)
        {
            var result = dbContext.Clients.AsQueryable();

            if (!string.IsNullOrWhiteSpace(city))
                result = result.Where(client => client.ClientLocation.City == city);

            if (!string.IsNullOrWhiteSpace(person.FirstName))
                result = result.Where(client => client.Person.FirstName == person.FirstName);

            if (!string.IsNullOrWhiteSpace(person.MiddleName))
                result = result.Where(client => client.Person.MiddleName == person.MiddleName);

            if (!string.IsNullOrWhiteSpace(person.LastName))
                result = result.Where(client => client.Person.LastName == person.LastName);

            return result.ToList();
        }
    }
}
