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
        
        public ICollection<Client> GetByPerson(Person person)
        {
            if (_collection.Any(x => x.Person == person))//need to override Equals in client
            {
                return _collection.Where(x => x.Person == person).ToList();
            }
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
