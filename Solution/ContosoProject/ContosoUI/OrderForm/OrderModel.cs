using Data.Design;
using Domain.DAO;
using Domain.Entities.Orders;

namespace ContosoUI.OrderForm
{
    public class OrderModel
    {
        private readonly IRepositoryFacade _facade = new EFRepositoryFacade();
        private readonly IOrderRepository _orderRepository;
        public readonly IProductRepository ProductRepository;
        public readonly IClientRepository ClientRepository;

        public OrderModel()
        {
            _orderRepository = _facade.OrderRepository;
            ProductRepository = _facade.ProductRepository;
            ClientRepository = _facade.ClientRepository;
        }
        public void Save(Order currentOrder)
        {
            _orderRepository.Save(currentOrder);
        }
        public void Create(Order currentOrder)
        {
            _orderRepository.Create(currentOrder);
        }

        public Order GetByNumber(string orderNumber)
        {
            return _orderRepository.GetByNumber(orderNumber);
        }

        public Order GetByID(int id)
        {
            return _orderRepository.Find(id);
        }
         
    }
}
