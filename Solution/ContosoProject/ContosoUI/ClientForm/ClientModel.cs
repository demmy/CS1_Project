using Data.Design;
using Domain.DAO;
using Domain.Entities.Clients;
using System.Linq;

namespace ContosoUI.ClientForm
{
    public class ClientModel
    {
        private readonly IRepositoryFacade _facade = new EFRepositoryFacade();
        public readonly IClientRepository ClientRepository;
        public readonly IOrderRepository OrderRepository;
        public ClientModel()
        {
            ClientRepository = _facade.ClientRepository;
            OrderRepository = _facade.OrderRepository;
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
