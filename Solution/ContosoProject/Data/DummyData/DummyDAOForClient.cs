using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;

namespace Data.DummyData
{
    class DummyDAOForClient : DummyDAOExtension<Client>, IClientRepository
    {
        public ICollection<Client> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Client> GetByCity(string city)
        {
            throw new NotImplementedException();
        }
    }
}
