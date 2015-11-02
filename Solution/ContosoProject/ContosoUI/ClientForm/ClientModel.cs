using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Clients;
using Data.EFRepository;

namespace ContosoUI.ClientForm
{
    public class ClientModel
    {
        private readonly ProjectContext _context = new ProjectContext();
        public readonly IClientRepository ClientRepository;
        public readonly IOrderRepository OrderRepository;
        public ClientModel()
        {
            ClientRepository = new EFClientDAO(_context);
            OrderRepository = new EFOrderDAO(_context);
        }
        public void Save(Client currentClient)
        {
            ClientRepository.Save(currentClient);
        }

        public void Create(Client newClient)
        {
            ClientRepository.Create(newClient);
        }

        public Client Find(int id)
        {
            return ClientRepository.Find(id);
        }

        public Client FindBy(string firstName, string lastName, string city)
        {
            var clientList = ClientRepository.FindBy(firstName, lastName, city);
            return clientList == null ?  null :  clientList.FirstOrDefault();
        }
    }
}
