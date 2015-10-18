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
                case PersonExstention.InformationAmount.City:
                {
                    return _collection.Where(x => x.ClientLocation.City == city).ToList();
                }
                case PersonExstention.InformationAmount.FirstName:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName).ToList();
                }
                case PersonExstention.InformationAmount.FirstNameCity:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.ClientLocation.City == city).ToList();
                }
                case PersonExstention.InformationAmount.FirstNameLastName:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.LastName == person.LastName).ToList();
                }
                case PersonExstention.InformationAmount.FirstNameLastNameCity:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.LastName == person.LastName && x.ClientLocation.City == city).ToList();
                }
                case PersonExstention.InformationAmount.FirstNameMiddleName:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.MiddleName == person.MiddleName).ToList();
                }
                case PersonExstention.InformationAmount.FirstNameMiddleNameCity:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.MiddleName == person.MiddleName && x.ClientLocation.City == city).ToList();
                }
                case PersonExstention.InformationAmount.FirstNameMiddleNameLastName:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.MiddleName == person.MiddleName && x.Person.LastName == person.LastName).ToList();
                }
                case PersonExstention.InformationAmount.FirstNameMiddleNameLastNameCity:
                {
                    return _collection.Where(x => x.Person.FirstName == person.FirstName && x.Person.MiddleName == person.MiddleName && x.Person.LastName == person.LastName && x.ClientLocation.City == city).ToList();
                }
                case PersonExstention.InformationAmount.LastName:
                {
                    return _collection.Where(x => x.Person.LastName == person.LastName).ToList();
                }
                case PersonExstention.InformationAmount.LastNameCity:
                {
                    return _collection.Where(x => x.Person.LastName == person.LastName && x.ClientLocation.City == city).ToList();
                }
                case PersonExstention.InformationAmount.MiddleName:
                {
                    return _collection.Where(x => x.Person.MiddleName == person.MiddleName).ToList();
                }
                case PersonExstention.InformationAmount.MiddleNameCity:
                {
                    return _collection.Where(x => x.Person.MiddleName == person.MiddleName && x.ClientLocation.City == city).ToList();
                }
                case PersonExstention.InformationAmount.MiddleNameLastName:
                {
                    return _collection.Where(x => x.Person.MiddleName == person.MiddleName && x.Person.LastName == person.LastName).ToList();
                }
                case PersonExstention.InformationAmount.MiddleNameLastNameCity:
                {
                    return _collection.Where(x => x.Person.MiddleName == person.MiddleName && x.Person.LastName == person.LastName && x.ClientLocation.City == city).ToList();
                }
                case PersonExstention.InformationAmount.NoInfo:
                {
                    throw new Exception();
                }
            }
            throw new Exception();
        }

    }
}
