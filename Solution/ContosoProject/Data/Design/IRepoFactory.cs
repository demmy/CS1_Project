using Data.EFRepository;
using Domain.DAO;

namespace Data.Factories
{
    public interface IRepositoryFactory<T>
    {
        IRepository<T> GetEFRepository(ProjectContext context);
        IRepository<T> GetDummyRepository();
    }
}
