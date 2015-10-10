using System.Collections.Generic;

namespace Domain.Entities.Comments
{
    public interface ICommentable
    {
        IReadOnlyCollection<Comment> Comments { get; }
    }
}
