using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.DAO
{
    public interface IClientRepository : IRepositoryExtension<Client>
    {
        ICollection<Client> GetByPerson(Person person);
        ICollection<Client> GetByCity(string city);
    }
}