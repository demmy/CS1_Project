using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Products;
using Domain.Entities.Users;

namespace Data.EFRepository
{
    public class EFCommentDAO:EFExtendedDAO<Comment>, ICommentRepository
    {
        public EFCommentDAO(ProjectContext context)
            : base(context)
        {

        }
        public ICollection<Comment> GetAllByUser(User user)
        {
            var commentsByUser = new List<Comment>();

            var userComments = from us in dbContext.Users
                from comment in us.Comments
                where comment.Author == user
                select comment;

            var orderComments = from order in dbContext.Orders
                from comment in order.Comments
                where comment.Author == user
                select comment;

            var clientComments = from client in dbContext.Clients
                from comment in client.Comments
                where comment.Author == user
                select comment;

            var productComments = from product in dbContext.Products
                from comment in product.Comments
                where comment.Author == user
                select comment;

            var categoryComments = from category in dbContext.Set<Category>()
                from comment in category.Comments
                where comment.Author == user
                select comment;

            commentsByUser.AddRange(userComments);
            commentsByUser.AddRange(orderComments);
            commentsByUser.AddRange(clientComments);
            commentsByUser.AddRange(productComments);
            commentsByUser.AddRange(categoryComments);

            return commentsByUser;
        }


        //public IQueryable<Comment> GetForUser(User user)
        //{
        //    return dbContext.Users.First(us => us == user).Comments.AsQueryable();
        //}

        //public IQueryable<Comment> GetForOrder(Domain.Entities.Orders.Order order)
        //{
        //    return dbContext.Orders.First(ord => ord == order).Comments.AsQueryable();
        //}

        //public IQueryable<Comment> GetForProduct(Product product)
        //{
        //    return dbContext.Set<Product>().First(pr => pr == product).Comments.AsQueryable();
        //}

        //public IQueryable<Comment> GetForClient(Domain.Entities.Client client)
        //{
        //    return dbContext.Clients.First(cli => cli == client).Comments.AsQueryable();
        //}

        //public IQueryable<Comment> GetForCategory(Category category)
        //{
        //    return dbContext.Set<Category>().First(categ => categ == category).Comments.AsQueryable();
        //}
    }
}
