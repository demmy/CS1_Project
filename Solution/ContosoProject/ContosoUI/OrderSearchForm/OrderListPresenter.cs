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

        public Client Client = new Client();
        public int ClientID
        {
            get { return (Client == null) ? 0 : Client.Id; }
            set
            {
                Client = ClientsList.FirstOrDefault(x => x.Id == value);
                NotifyPropertyChanged();
            }
        }

        Status Status;
        public Status StatusEnum
        {
            get
            { return Status; }
            set
            {
                this.Status = value;
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
            if (OrderNumber != null && Client != null && Status != Status.Undefined)
                orders = model.GetBy(OrderNumber, Status, Client).ToList(); 
            else
                orders = model.GetAll().ToList();

            OrdersList = new BindingList<Order>(orders);
            NotifyPropertyChanged();
        }

        public void Clear()
        {
            OrderNumber = "";
            Client = null;
            Status = Status.Undefined;
            OrdersList.Clear();
        }
    }
}
