using Data.DummyData;
using Domain.DAO;
using Domain.Entities.Orders;

namespace ContosoUI.OrderForm
{
    public class OrderModel
    {
        private readonly IOrderRepository _repository = new DummyDAOForOrder();

        public void Save(Order currentOrder)
        {
            _repository.Save(currentOrder);
        }
        public void Create(Order currentOrder)
        {
            _repository.Create(currentOrder);
        }

        public Order GetByNumber(string orderNumber)
        {
            return _repository.GetByNumber(orderNumber);
        }

        public Order GetByID(int id)
        {
            return _repository.Find(id);
        }
         
    }
}
