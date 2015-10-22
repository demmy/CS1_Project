using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using DevExpress.XtraRichEdit.Commands;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Orders;

namespace ContosoUI.NicksForms.Order_form
{
    class OrderModel
    {
        private IOrderRepository _order = new DummyDAOForOrder();

        public void Save(Order currentOrder)
        {
            _order.Save(currentOrder);
        }
        public void Create(Order currentOrder)
        {
            _order.Create(currentOrder);
        }

        public Order GetByNumber(string orderNumber)
        {
            return _order.GetByNumber(orderNumber);
        }
         
    }
}
