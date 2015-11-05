using Data.Design;
using Domain.DAO;
using Domain.Entities.Clients;
using System.Linq;

namespace ContosoUI.ClientForm
{
    public class ClientModel: Model
    {
        public ClientModel()
            :base()
        {

        }
        public IClientRepository ClientRepository
        {
            get { return Facade.ClientRepository; }
        }
        public IOrderRepository OrderRepository
        {
            get { return Facade.OrderRepository; }
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
