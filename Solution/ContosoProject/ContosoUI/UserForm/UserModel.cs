using Data.DummyData;
using Data.EFRepository;
using Domain.DAO;
using Domain.Entities.Users;

namespace ContosoUI.UserForm
{
    public class UserModel
    {
        ProjectContext context = new ProjectContext();

        public readonly IRoleRepository RoleRepository;
        public readonly IUserRepository UserRepository;
        public UserModel()
        {
            UserRepository = new EFUserDAO(context);
            RoleRepository = new EFRoleDAO(context);
        }
        public void Save(User currentUser)
        {
            UserRepository.Save(currentUser);
        }

        public void Create(User currentUser)
        {
            UserRepository.Create(currentUser);
        }

        public User Find(int id)
        {
            return UserRepository.Find(id);
        }
    }
}
