using System.Collections.Generic;
using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Products;

namespace Data.DummyData
{
    class DummyDAOForComment : DummyDAOExtension<Comment>, ICommentRepository
    {
        public DummyDAOForComment()
        {
            _collection = (IList<Comment>) GodCommentsCollection.Target;
        }
    }
}
