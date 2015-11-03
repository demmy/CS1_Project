using Domain.DAO;
namespace Data.Design
{
    public interface IRepositoryFacade
    {
        IClientRepository ClientRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        IPermissionRepository PermissionRepository { get; }
        ICommentRepository CommentRepository { get; } 
    }
}
