using System;
using System.Collections.Generic;
using Domain.Entities.Comments;
using Domain.Entities.Users;

namespace Data.StoreData
{
    static partial class Storage
    {
        public static List<Comment> GodComments = new List<Comment>
        {
            new Comment{Text = "the best man ever", EntityType = EntityType.User, Id = 1, IsActive = true, User = Users[2], Date = DateTime.Now},
            new Comment{Text = "Good guy, you can believe him in any case", EntityType = EntityType.User, Id = 2, IsActive = true, User = Users[3], Date = DateTime.Now},
            new Comment{Text = "Don't Troube him too much, he doesn't like this", EntityType = EntityType.User, Id = 3, IsActive = true, User = Users[4], Date = DateTime.Now.AddDays(-3)},
            new Comment{Text = "Gon't try to kick him", EntityType = EntityType.User, Id = 4, IsActive = true, User = Users[2], Date = DateTime.Now.AddDays(-30)}
        };

        public static List<User> Users = new List<User>
        {
            new User(GodComments) {Date = new DateTime(1999, 11, 4, 12, 34, 08), Role = Roles["Admin"], Id = 1, IsActive = true, User = null, Login = "God", Password = "safe342g"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 14, 02), Role = Roles["Admin"], Id = 2, IsActive = true, User = Users[0], Login = "FirstSimpleAdmin", Password = "adm123in"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = Roles["Admin"], Id = 3, IsActive = false, User = Users[0], Login = "SecondSimpleAdmin", Password = "min43ad"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = Roles["Manager"], Id = 4, IsActive = true, User = Users[1], Login = "ActiveManager", Password = "manageR323"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = Roles["Director"], Id = 5, IsActive = true, User = Users[1], Login = "SecondSimpleAdmin", Password = "min43ad"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = Roles["Manager"], Id = 6, IsActive = true, User = Users[2], Login = "SecondSimpleAdmin", Password = "min43ad"}
        };
    }
}
