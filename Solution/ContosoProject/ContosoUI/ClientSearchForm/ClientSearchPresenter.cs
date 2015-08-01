using Data.StoreData;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.ClientSearchForm
{
    public class ClientSearchPresenter : INotifyPropertyChanged
    {
        private readonly IClientSearchView view;
        private readonly ClientSearchModel model;
        public event PropertyChangedEventHandler PropertyChanged;

        private string city;
        private string firstName;
        private string lastName;
        private BindingList<Client> clientsList;

        public ClientSearchPresenter(IClientSearchView view, ClientSearchModel model)
        {
            this.view = view;
            this.model = model;
            clientsList = new BindingList<Client>(Storage.Clients);
        }

        public string City 
        {
            get { return city; }
            set
            {
                if (value != this.city)
                {
                    this.city = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != this.firstName)
                {
                    this.firstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value != this.lastName)
                {
                    this.lastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public BindingList<Client> Clients
        {
            get { return clientsList; }
            set
            {
                if (value != this.clientsList)
                {
                    this.clientsList = value;
                    //NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void AddClient()
        {
            UserForm.UserForm addClientForm = new UserForm.UserForm();
            addClientForm.Show();
        }

        public void EditClient(int id)
        {
            UserForm.UserForm editClientForm = new UserForm.UserForm(id);           
            editClientForm.Show();
        }

        public void Search()
        {
            var clients = model.SearchClient(FirstName, LastName, City);
            Clients = new BindingList<Client>((IList<Client>)clients);
        }

        public void Clear()
        {
            City = "";
            FirstName = "";
            LastName = "";
            Clients = new BindingList<Client>(Storage.Clients);
        }

    }
}
