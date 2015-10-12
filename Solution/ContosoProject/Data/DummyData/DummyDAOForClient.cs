using System;
using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities;

namespace Data.DummyData
{
    class DummyDAOForClient : DummyDAOExtension<Client>, IClientRepository
    {
        public DummyDAOForClient()
        {
            _collection = (IList<Client>) ClientsCollection.Target;
        }
        public ICollection<Client> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Client> GetByCity(string city)
        {
            if (_collection.Any(x => x.ClientLocation.City == city))
            {
                return _collection.Where(x => x.ClientLocation.City == city).ToList();
            }
            throw new Exception();
        }
    }
}
