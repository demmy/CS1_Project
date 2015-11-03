using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Clients;
using System.Data.Entity;

namespace Data.EFRepository
{
    public class EFClientDAO: EFExtendedDAO<Client>, IClientRepository
    {
        public EFClientDAO(ProjectContext context)
            : base(context)
        {

        }
        /// <summary>
        /// Specific query, finds the Clients that mach each not-null parameter
        /// </summary>
        /// <param name="firstName">Client's First Name</param>
        /// <param name="lastName">Client;s Last Name</param>
        /// <param name="city">The city where client lives</param>
        /// <returns>Collection of such clients</returns>
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
