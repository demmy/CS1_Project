using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Clients;

namespace Data.EFRepository
{
    public class EFOrderDAO: EFExtendedDAO<Order>, IOrderRepository
    {
        public EFOrderDAO(ProjectContext context)
            : base(context)
        {

        }

        /// <summary>
        /// The method to search the Order by some kind of "mask"
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public ICollection<Order> GetByStatus(Status status)
        {
            return dbContext.Orders.AsQueryable()
                .Where(order => order.Status == status)
                .ToList();
        }


        /// <summary>
        /// Gets all orders of any Client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public ICollection<Order> GetByClient(Client client)
        {
            return (from order in dbContext.Orders
                        where order.Client == client
                            select order)
                                .ToList();
        }
        /// <summary>
        /// Gets all Orders, which have product in their own
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public ICollection<Order> GetByProduct(Product product)
        {
            return (from order in dbContext.Orders
                        where order.Contains(product)
                            select order)
                                .ToList();
        }

        /// <summary>
        /// Adds new orderItem to Order, if Order doesn't exists in db yet => we create new Order
        /// </summary>
        /// <param name="order"></param>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        public void AddOrder(Order order, Product product, int quantity)
        {
            var tempOrder = dbContext.Orders.FirstOrDefault(ord => ord == order) ?? order;
            tempOrder.AddOrder(product, quantity);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Removes orderItem from the collection in Order
        /// </summary>
        /// <param name="order"></param>
        /// <param name="product"></param>
        public void RemoveOrder(Order order, Product product)
        {
            dbContext.Orders
                .FirstOrDefault(ord => ord == order)
                .RemoveOrder(product);
            dbContext.SaveChanges();
        }
        /// <summary>
        /// Edit the orderItem that is in Order
        /// </summary>
        /// <param name="order"></param>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        public void EditOrder(Order order, Product product, int quantity)
        {
            dbContext.Orders
                .FirstOrDefault(ord => ord == order)
                .EditOrder(product, quantity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <param name="status"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        public ICollection<Order> GetBy(string orderNumber, Status status, Client client)
        {
            var result = dbContext.Orders.AsQueryable();
            if (!string.IsNullOrWhiteSpace(orderNumber))
                return result.Where(order => order.OrderNumber == orderNumber).ToList();

            if (client != null)
                result = result.Where(order => order.Client == client);

            return result.Where(order => order.Status == status).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <returns></returns>
        public Order GetByNumber(string orderNumber)
        {
            return dbContext.Orders.AsQueryable().First(order => order.OrderNumber == orderNumber);
        }
    }
}
