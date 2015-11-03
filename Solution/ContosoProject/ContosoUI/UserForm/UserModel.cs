using Data.Design;
using Data.DummyData;
using Data.EFRepository;
using Domain.DAO;
using Domain.Entities.Users;

namespace ContosoUI.UserForm
{
    public class UserModel
    {
        private readonly IRepositoryFacade _facade = new EFRepositoryFacade();

        public readonly IRoleRepository RoleRepository;
        public readonly IUserRepository UserRepository;
        public UserModel()
        {
            UserRepository = _facade.UserRepository;
            RoleRepository = _facade.RoleRepository;
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
