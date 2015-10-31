using Domain.DAO;

namespace Data.Factories
{
    public interface IRepositoryFactory<T>
    {
        IRepository<T> GetEFRepository();
        IRepository<T> GetDummyRepository();
    }
}
