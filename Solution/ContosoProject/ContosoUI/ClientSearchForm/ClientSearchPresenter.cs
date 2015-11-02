using ContosoUI.Annotations;
using Data.DummyData;
using Data.EFRepository;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.ClientSearchForm
{
    public class ClientSearchPresenter : Presenter, ISearchPresenter
    {
        private readonly ProjectContext _context = new ProjectContext();
        private readonly IClientSearchView view;
        private readonly IClientRepository model;

        private BindingList<Client> clientsList = new BindingList<Client>();

        public ClientSearchPresenter(IClientSearchView view)
        {
            model = new EFClientDAO(_context);
            this.view = view;
        }

        private string city;
        public string City 
        {
            get { return city; }
            set
            {
                this.city = value;
                NotifyPropertyChanged();
            }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                this.firstName = value;
                NotifyPropertyChanged();
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                this.lastName = value;
                NotifyPropertyChanged();             
            }
        }

        public BindingList<Client> Clients
        {
            get { return clientsList; }
            set
            {
                this.clientsList = value;
                NotifyPropertyChanged();
            }
        }

        public void Edit(int id)
        {
            ClientForm.ClientView editClientForm = new ClientForm.ClientView(id) { Text = "Client editing.."};
            editClientForm.MdiParent = Program.MainForm;
            editClientForm.Show();
        }

        public void Search()
        {
            List<Client> clients;
            if (City != null && FirstName != null && LastName != null)
                clients = model.FindBy(FirstName, LastName, City).ToList();
            else
                clients = model.GetAll().ToList();

            Clients = new BindingList<Client>(clients);
        }

        public void Clear()
        {
            City = "";
            FirstName = "";
            LastName = "";
            Clients.Clear();
        }

    }
}
