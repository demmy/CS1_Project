using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ContosoUI.Annotations;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Clients;

namespace ContosoUI.OrderForm
{
    public class OrderPresenter : Presenter, IViewPresenter
    {
        private OrderModel _model;
        private IOrderView _view;
        IProductRepository _produtRepository = new DummyDAOForProduct();
        IClientRepository _clientRepository = new DummyDAOForClient();

        public BindingList<Product> Products
        {
            get { return new BindingList<Product>(_produtRepository.GetAll().ToList()); }
        } 

        private Order _order = new Order(new List<Comment>(), new List<OrderItem>());
        private Client _client = new Client();

        private string _orderNumber = string.Empty;
        private Status _status = Status.Opened;
        private DateTime _date = DateTime.Now;
        
        private BindingList<Comment> _comments = new BindingList<Comment>(); 
        private BindingList<OrderItem> _orderItems = new BindingList<OrderItem>();
        public bool State { get; set; }

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
            Order orderToSave = new Order(_comments, new List<OrderItem>(_orderItems))
            {
                Client = _client,
                Date = _date,
                IsActive = State,
                Status = _status,
                OrderNumber = _orderNumber
            };

            if (orderToSave.Id != 0)
            {
                if (!_model.GetByNumber(orderToSave.OrderNumber).Equals(orderToSave))
                {
                    _model.Save(orderToSave);
                    _order = orderToSave;
                }
            }
            else
            {
                if (_model.GetByNumber(orderToSave.OrderNumber) == null)
                {
                    _model.Create(orderToSave);
                    _order = orderToSave;
                }
                else
                {
                    MessageBox.Show("Order with this number already exists, use another one, please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        public void New()
        {
            _order = new Order();
            _client = new Client();
            _orderNumber = string.Empty;
            _status = Status.Opened;
            _date = DateTime.Now;
            State = true;
            _orderItems = new BindingList<OrderItem>();
            _comments = new BindingList<Comment>();
        }

        public void SaveAndNew()
        {
            Save();
            New();
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
