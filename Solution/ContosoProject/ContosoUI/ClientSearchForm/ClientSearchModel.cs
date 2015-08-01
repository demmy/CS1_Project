using Data.DummyData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.ClientSearchForm
{
    public class ClientSearchModel
    {
        IClientRepository client = new DummyDAOForClient();

        public ICollection<Client> SearchClient(string firstName, string lastName, string city)
        {
            return client.FindBy(firstName, lastName, city);
        }
    }
}
