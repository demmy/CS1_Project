using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;

namespace Data.DummyData
{
    public class DummyDAOForClient : DummyDAOExtension<Client>, IClientRepository
    {
        public DummyDAOForClient()
        {
            _collection = Storage.Clients;
        }
        public ICollection<Client> GetByName(string name)
        {
            if (_collection.Any(x => x.Person.FirstName == name))
            {
                return _collection.Where(x => x.Person.FirstName == name).ToList();
            }
            throw new Exception();
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
