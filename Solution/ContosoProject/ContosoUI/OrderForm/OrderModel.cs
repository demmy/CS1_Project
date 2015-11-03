using Data.DummyData;
using Data.EFRepository;
using Domain.DAO;
using Domain.Entities.Orders;

namespace ContosoUI.OrderForm
{
    public class OrderModel
    {
        private readonly ProjectContext _context = new ProjectContext();
        private readonly IOrderRepository _orderRepository;
        public readonly IProductRepository ProductRepository;
        public readonly IClientRepository ClientRepository;

        public OrderModel()
        {
            _orderRepository = new EFOrderDAO(_context);
            ProductRepository = new EFProductDAO(_context);
            ClientRepository = new EFClientDAO(_context);
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
