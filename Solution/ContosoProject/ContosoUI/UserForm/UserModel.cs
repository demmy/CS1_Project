using Data.DummyData;
using Domain.DAO;
using Domain.Entities.Users;

namespace ContosoUI.UserForm
{
    public class UserModel
    {
        IRepository<User> user = new DummyDAO<User>();

        public void Save(User currentUser)
        {
            user.Save(currentUser);
        }

        public void Create(User currentUser)
        {
            user.Create(currentUser);
        }

        public User Find(int id)
        {
            return user.Find(id);
        }
    }
}
