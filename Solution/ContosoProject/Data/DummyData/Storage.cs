using System;
using System.Collections.Generic;
using Domain.Entities.Comments;
using Domain.Entities.Users;

namespace Data.DummyData
{
    static partial class Storage
    {
        public static List<Comment> GodComments = new List<Comment>
        {
            new Comment{Text = "the best man ever"},
            new Comment{Text = "Good guy, you can believe him in any case"},
            new Comment{Text = "Don't Troube him too much, he doesn't like this"},
            new Comment{Text = "Gon't try to kick him"}
        };

        public static List<User> Users = new List<User>
        {
            new User(GodComments) {Date = new DateTime(1999, 11, 4, 12, 34, 08), Role = new Role(AdminPermissions), Id = 1, IsActive = true, User = null, Login = "God", Password = "safe342g"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 14, 02), Role = new Role(AdminPermissions), Id = 2, IsActive = true, User = Users[0], Login = "FirstSimpleAdmin", Password = "adm123in"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = new Role(AdminPermissions), Id = 3, IsActive = true, User = Users[0], Login = "SecondSimpleAdmin", Password = "min43ad"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = new Role(ManagerPermissions), Id = 4, IsActive = true, User = Users[1], Login = "ActiveManager", Password = "manageR323"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = new Role(DirectorPermissions), Id = 5, IsActive = true, User = Users[1], Login = "SecondSimpleAdmin", Password = "min43ad"},
            new User(new List<Comment>()) {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = new Role(ManagerPermissions), Id = 6, IsActive = true, User = Users[2], Login = "SecondSimpleAdmin", Password = "min43ad"}
        };
    }
}
