using Domain.DAO;
using Domain.Entities.Comments;

namespace Data.DummyData
{
    public class DummyDAOForComment : DummyDAO<Comment>, ICommentRepository
    {
    }
}
