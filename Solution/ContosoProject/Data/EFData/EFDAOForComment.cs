using Domain.DAO;
using Domain.Entities.Comments;

namespace Data.EFData
{
    class EFDAOForComment : EFDAO<Comment>, ICommentRepository
    {
    }
}
