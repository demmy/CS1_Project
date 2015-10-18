using System;
using System.Collections.Generic;
using System.Linq;
using Data.StoreData;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;

namespace Data.DummyData
{
    class DummyDAOForClient : DummyDAOExtension<Client>, IClientRepository
    {
        
        public DummyDAOForClient()
        {
            _collection = Storage.Clients;
        }

        public ICollection<Client> FindBy(Person person, string city)
        {
            switch (person.GetInformationAmount(city))
            {
                case PersonExtention.InformationAmount.City:
                {
                    return _collection.Where(x => x.ClientLocation.City == city).ToList();
                }
                case PersonExtention.InformationAmount.FirstName:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName).ToList();
                }
                case PersonExtention.InformationAmount.FirstNameCity:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.ClientLocation.City == city).ToList();
                }
                case PersonExtention.InformationAmount.FirstNameLastName:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.LastName == person.LastName).ToList();
                }
                case PersonExtention.InformationAmount.FirstNameLastNameCity:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.LastName == person.LastName && x.ClientLocation.City == city).ToList();
                }
                case PersonExtention.InformationAmount.FirstNameMiddleName:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.MiddleName == person.MiddleName).ToList();
                }
                case PersonExtention.InformationAmount.FirstNameMiddleNameCity:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.MiddleName == person.MiddleName && x.ClientLocation.City == city).ToList();
                }
                case PersonExtention.InformationAmount.FirstNameMiddleNameLastName:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.MiddleName == person.MiddleName && x.Person.LastName == person.LastName).ToList();
                }
                case PersonExtention.InformationAmount.FirstNameMiddleNameLastNameCity:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.MiddleName == person.MiddleName && x.Person.LastName == person.LastName && x.ClientLocation.City == city).ToList();
                }
                case PersonExtention.InformationAmount.LastName:
                {
                    return _collection.Where(x => x.Person.LastName == person.LastName).ToList();
                }
                case PersonExtention.InformationAmount.LastNameCity:
                {
                    return _collection.Where(x => x.Person.LastName == person.LastName && x.ClientLocation.City == city).ToList();
                }
                case PersonExtention.InformationAmount.MiddleName:
                {
                    return _collection.Where(x => x.Person.MiddleName == person.MiddleName).ToList();
                }
                case PersonExtention.InformationAmount.MiddleNameCity:
                {
                    return _collection.Where(x => x.Person.MiddleName == person.MiddleName && x.ClientLocation.City == city).ToList();
                }
                case PersonExtention.InformationAmount.MiddleNameLastName:
                {
                    return _collection.Where(x => x.Person.MiddleName == person.MiddleName && x.Person.LastName == person.LastName).ToList();
                }
                case PersonExtention.InformationAmount.MiddleNameLastNameCity:
                {
                    return _collection.Where(x => x.Person.MiddleName == person.MiddleName && x.Person.LastName == person.LastName && x.ClientLocation.City == city).ToList();
                }
                case PersonExtention.InformationAmount.NoInfo:
                {
                    throw new Exception();
                }
            }
            throw new Exception();
        }

    }
}
