using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using ContosoUI.Annotations;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Orders;

namespace ContosoUI.OrderForm
{
    public class OrderPresenter : Presenter, IViewPresenter
    {
        private OrderModel _model;
        private IOrderView _view;

        IClientRepository _clientRepository = new DummyDAOForClient();

        private Order _order = new Order(new List<Comment>(), new List<OrderItem>());
        private Client _client = new Client();

        private string _orderNumber = string.Empty;
        private Status _status = Status.Opened;
        private DateTime _date = DateTime.Now;
        
        private BindingList<Comment> _comments = new BindingList<Comment>(); 
        private BindingList<OrderItem> _orderItems = new BindingList<OrderItem>();

        public OrderPresenter(OrderModel model, IOrderView view)
        {
            _model = model;
            _view = view;
        }

        public void UseOrderWithID(int id)
        {
            _order = _model.GetByID(id);

            _client = _order.Client;
            _orderNumber = _order.OrderNumber;
            _status = _order.Status;
            _date = _order.Date;
            _comments = new BindingList<Comment>(_order.Comments.ToList());
            _orderItems = new BindingList<OrderItem>(_order.OrderItems);
        }

        public string OrderNumber
        {
            get { return _orderNumber; }
            set
            {
                if (value == _orderNumber) return;
                _orderNumber = value;
                NotifyPropertyChanged();
            }
        }

        public Status Status
        {
            get { return _status; }
            set
            {
                if (value == _status) return;
                _status = value;
                NotifyPropertyChanged();
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value.Equals(_date)) return;
                _date = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Comment> Comments
        {
            get { return _comments; }
            set
            {
                if (Equals(value, _comments)) return;
                _comments = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<OrderItem> OrderItems
        {
            get { return _orderItems; }
            set
            {
                if (Equals(value, _orderItems)) return;
                _orderItems = value;
                NotifyPropertyChanged();
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
                _model.Create(orderToSave);
                return;
            }
            _model.Save(orderToSave);
        }

        public void Clear()
        {
            _order = new Order();
            _client = new Client();
            _orderNumber = string.Empty;
            _status = Status.Opened;
            _date = DateTime.Now;
            _orderItems = new BindingList<OrderItem>();
            _comments = new BindingList<Comment>();
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


        public List<Status> StatusEnum
        {
            get
            {
                return Enum.GetValues(typeof(Status)).Cast<Status>().ToList();
            }
        }
    }
}
