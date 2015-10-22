using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContosoUI.Annotations;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using Domain.Entities.Users;

namespace ContosoUI.NicksForms.Order_form
{
    class OrderPresenter : INotifyPropertyChanged
    {
        private OrderModel _model;
        private IOrderView _view;
        public event PropertyChangedEventHandler PropertyChanged = delegate(object sender, PropertyChangedEventArgs args) {  };

        private string _orderNumber = string.Empty;
        private Status _status = Status.Opened;
        private DateTime _date = DateTime.Now;
        private Client _client = new Client();

        private Order _order = new Order(new List<Comment>(), new List<OrderItem>());

        private BindingList<Comment> _comments = new BindingList<Comment>(); 
        private BindingList<OrderItem> _orderItems = new BindingList<OrderItem>();

        IClientRepository _clientRepository = new DummyDAOForClient();

        public OrderPresenter(OrderModel model, IOrderView view)
        {
            _model = model;
            _view = view;
        }
        
        public OrderPresenter(OrderModel model, IOrderView view, Order order)
        {
            _model = model;
            _view = view;
            _order = order;
            _client = _order.Client;
            _comments =  new BindingList<Comment>(_order.Comments.ToList());
            _orderItems = new BindingList<OrderItem>(_order.OrderItems);
        }

        public string OrderNumber
        {
            get { return _orderNumber; }
            set
            {
                if (value != _orderNumber)
                {
                    _orderNumber = value;
                    NotifyPropertyChanged("OrderNumber");
                }
            }
        }

        public Status Status
        {
            get { return _status; }
            set
            {
                if (value != _status)
                {
                    _status = value;
                    NotifyPropertyChanged("Status");
                }
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value != _date)
                {
                    _date = value;
                    NotifyPropertyChanged("Date");
                }
            }
        }

        public void Save()
        {
            Order orderToSave = new Order(_comments, new List<OrderItem>(_orderItems)) { Client = _client, Date = _date, IsActive = true, Status = _status, OrderNumber =  _orderNumber};
            try
            {
                _model.GetByNumber(_orderNumber);
            }
            catch (Exception)
            {
                _model.Save(orderToSave);
                return;
            }
            _model.Create(orderToSave);
        }

        public void Clear()
        {
            
        }

        public void SaveAndNew()
        {
            Save();
            Clear();
        }

        public BindingList<Client> ClientList
        {
            get { return new BindingList<Client>(_clientRepository.GetAll().ToList()); }
        }

        public BindingList<OrderItem> OrderItems
        {
            get { return _orderItems;}
            set
            {
                    //need to implement the comparing of lists
                    _orderItems = value;
                    NotifyPropertyChanged("OrderItems");                
            }
        }
        public BindingList<Comment> Comments
        {
            get { return _comments; }
            set
            {
                //need to implement the comparing of lists
                _comments = value;
                NotifyPropertyChanged("Comments");

            }
        } 

        public List<Status> StatusEnum
        {
            get
            {
                return Enum.GetValues(typeof(Status)).Cast<Status>().ToList();
            }
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ShowView()
        {
            _view.ShowView();
        }
    }
}
