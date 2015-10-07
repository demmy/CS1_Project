using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class ExtendedEntity
    {
        public ExtendedEntity(int id, bool isActive, User user, DateTime date)
        { }

        public int GetNewID
        { get { return 0; } }
    }

    class User
    {
        public User GetCurrentUser
        { get { return new User(); } }
    }
    class Client
    {
    }
    enum EntityType { }

    class Category
    {
    }

    class Comment
    {
    }
    interface ICommentable
    {
        IReadOnlyList<Comment> Comments { get; }
    }
}
