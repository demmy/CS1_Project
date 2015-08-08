using ContosoUI.Annotations;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.OrderSearchForm
{
    public class OrderListPresenter : Presenter, ISearchPresenter
    {
        private readonly IOrderListView view;
        private readonly IOrderRepository model = new DummyDAOForOrder();
        IClientRepository clientRepo = new DummyDAOForClient();
        public BindingList<Client> ClientsList;
        public BindingList<Status> StatusList = new BindingList<Status>(Enum.GetValues(typeof(Status)).Cast<Status>().ToList());

        IClientRepository clients = new DummyDAOForClient();

        private BindingList<Order> ordersList = new BindingList<Order>();

        public OrderListPresenter(IOrderListView view)
        {
            this.view = view;
            ClientsList = new BindingList<Client>(clientRepo.GetAll().ToList());
        }

        private string orderNumber = string.Empty;
        public string OrderNumber
        {
            get { return orderNumber; }
            set
            {
                this.orderNumber = value;
                NotifyPropertyChanged();
            }
        }

        Client Client;
        public int ClientID
        {
            get { return (Client == null) ? 0 : Client.Id; }
            set
            {
                Client = ClientsList.FirstOrDefault(x => x.Id == value);
                NotifyPropertyChanged();
            }
        }

        public Status status;
        public Status StatusEnum
        {
            get
            { return status; }
            set
            {
                this.status = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Order> OrdersList
        {
            get { return ordersList; }
            set
            {
                if (value != this.ordersList)
                {
                    this.ordersList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void Edit(int id)
        {
            OrderForm.OrderForm editOrderForm = new OrderForm.OrderForm(id);
            editOrderForm.MdiParent = Program.MainForm;
            editOrderForm.Show();
        }

        public void Search()
        {
            List<Order> orders;
            if (string.IsNullOrEmpty(OrderNumber) && Client == null && StatusEnum == Status.All)
                orders = model.GetAll().ToList();
            else
                orders = model.GetBy(OrderNumber, StatusEnum, Client).ToList(); 

            OrdersList = new BindingList<Order>(orders);
        }

        public void Clear()
        {
            OrderNumber = null;
            Client = null;            
            StatusEnum = Status.All;
            OrdersList.Clear();
        }
    }
}
