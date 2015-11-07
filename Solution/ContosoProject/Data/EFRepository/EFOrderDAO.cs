using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
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

        public new void Create(Order entity)
        {
            dbContext.Orders.Add(entity);
            dbContext.SaveChanges();
        }

        public new void Save(Order entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public new void Delete(Order entity)
        {
            dbContext.Orders.Remove(entity);
            dbContext.SaveChanges();
        }

        public new void Delete(int id)
        {
            var ent = Find(id);
            Delete(ent);
            dbContext.SaveChanges();
        }

        public new Order Find(int id)
        {
            return dbContext.Orders
                .Include(ord => ord.OrderItems)
                .FirstOrDefault(x => x.Id == id);
        }

        public new IQueryable<Order> GetAll()
        {
            return dbContext.Orders.Include(order => order.OrderItems).AsQueryable();
        }

        /// <summary>
        /// The method to search the Order by some kind of "mask"
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public ICollection<Order> GetByStatus(Status status)
        {
            return dbContext.Orders.Include(ord => ord.OrderItems)
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
            return (from order in dbContext.Orders.Include(ord => ord.OrderItems)
                        where order.Client.Id == client.Id
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
            return (from order in dbContext.Orders.Include(ord => ord.OrderItems)
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
            var tempOrder = dbContext.Orders.Include(ord => ord.OrderItems).FirstOrDefault(ord => ord == order) ?? order;
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
            dbContext.Orders.Include(ord => ord.OrderItems)
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
                result = result.Where(order => order.Client.Id == client.Id);

            return result.Include(ord => ord.OrderItems).Where(order => order.Status == status).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <returns></returns>
        public Order GetByNumber(string orderNumber)
        {
            return dbContext.Orders.Include(ord => ord.OrderItems).FirstOrDefault(order => order.OrderNumber == orderNumber);
        }
    }
}
