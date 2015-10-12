using Domain.DAO;
using Domain.Entities.Comments;

namespace Data.DummyData
{
    class DummyDAOForComment : DummyDAOExtension<Comment>, ICommentRepository
    {
    }
}
