using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities;

namespace Data.DummyData
{
    class DummyDAOForClient : DummyDAOExtension<Client>, IClientRepository
    {
        public ICollection<Client> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Client> GetByCity(string city)
        {
            throw new System.NotImplementedException();
        }
    }
}
