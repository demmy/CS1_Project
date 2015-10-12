using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Clients;

namespace Domain.DAO
{
    public interface IClientRepository : IRepository<Client>
    {
        ICollection<Client> GetByName(string name);
        ICollection<Client> GetByCity(string city);
    }
}