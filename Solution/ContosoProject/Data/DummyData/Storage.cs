using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Domain.Entities.Users;

namespace Data.DummyData
{
    class PermissionDictionary:KeyedCollection<string, Permission>
    {
        protected override string GetKeyForItem(Permission item)
        {
            return item.Title;
        }
    }
    static class Storage
    {
        #region Permissions

        private static readonly PermissionDictionary Permissions = new PermissionDictionary
        {
            new Permission {Description = "", Id = 1, IsActive = true, Title = "Add User"},
            new Permission {Description = "", Id = 2, IsActive = true, Title = "Edit User"},
            new Permission {Description = "", Id = 3, IsActive = true, Title = "Activate User"},
            new Permission {Description = "", Id = 4, IsActive = true, Title = "Deactivate User"},

            new Permission {Description = "", Id = 5, IsActive = true, Title = "Add Product"},
            new Permission {Description = "", Id = 6, IsActive = true, Title = "Edit Product"},
            new Permission {Description = "", Id = 7, IsActive = true, Title = "Activate Product"},
            new Permission {Description = "", Id = 8, IsActive = true, Title = "Deactivate Product"},

            new Permission {Description = "", Id = 9, IsActive = true, Title = "Add Client"},
            new Permission {Description = "", Id = 10, IsActive = true, Title = "Edit Client"},

            new Permission {Description = "", Id = 11, IsActive = true, Title = "Add Comment"},
            new Permission {Description = "", Id = 12, IsActive = true, Title = "Edit Comment"},

            new Permission {Description = "", Id = 13, IsActive = true, Title = "Add Order"},
            new Permission {Description = "", Id = 14, IsActive = true, Title = "Edit Order"},
            new Permission {Description = "", Id = 15, IsActive = true, Title = "Activate Order"},
            new Permission {Description = "", Id = 16, IsActive = true, Title = "Deactivate Order"}
        };

        private static readonly List<Permission> AdminPermissions = new List<Permission>
        {
            Permissions["Add User"],
            Permissions["Edit User"],
            Permissions["Activate User"],
            Permissions["Deactivate User"],
            Permissions["Add Product"],
            Permissions["Edit Product"],
            Permissions["Activate Product"],
            Permissions["Deactivate Product"],
            Permissions["Add Client"],
            Permissions["Edit Client"],
            Permissions["Add Comment"],
            Permissions["Edit Comment"],
            Permissions["Add Order"],
            Permissions["Edit Order"],
            Permissions["Activate Order"],
            Permissions["Deactivate order"]
        };

        private static readonly List<Permission> DirectorPermissions = new List<Permission>
        {
            Permissions["Add Product"],
            Permissions["Edit Product"],
            Permissions["Activate Product"],
            Permissions["Deactivate Product"],
            Permissions["Add Client"],
            Permissions["Edit Client"],
            Permissions["Add Comment"],
            Permissions["Edit Comment"],
            Permissions["Add Order"],
            Permissions["Edit Order"],
            Permissions["Activate Order"],
            Permissions["Deactivate order"]
        };

        private static readonly List<Permission> ManagerPermissions = new List<Permission>
        {
            Permissions["Add Client"],
            Permissions["Edit Client"],
            Permissions["Add Comment"],
            Permissions["Edit Comment"],
            Permissions["Add Order"],
            Permissions["Edit Order"],
            Permissions["Activate Order"],
            Permissions["Deactivate order"]
        };

        #endregion
        
        public static List<User> Users = new List<User>
        {
            new User {Date = new DateTime(1999, 11, 4, 12, 34, 08), Role = new Role(AdminPermissions), Id = 1, IsActive = true, User = null, Login = "God", Password = "safe342g"},
            new User {Date = new DateTime(1999, 11, 5, 13, 14, 02), Role = new Role(AdminPermissions), Id = 2, IsActive = true, User = Users[0], Login = "FirstSimpleAdmin", Password = "adm123in"},
            new User {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = new Role(AdminPermissions), Id = 3, IsActive = true, User = Users[0], Login = "SecondSimpleAdmin", Password = "min43ad"},
            new User {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = new Role(ManagerPermissions), Id = 4, IsActive = true, User = Users[1], Login = "ActiveManager", Password = "manageR323"},
            new User {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = new Role(DirectorPermissions), Id = 5, IsActive = true, User = Users[1], Login = "SecondSimpleAdmin", Password = "min43ad"},
            new User {Date = new DateTime(1999, 11, 5, 13, 16, 11), Role = new Role(ManagerPermissions), Id = 6, IsActive = true, User = Users[2], Login = "SecondSimpleAdmin", Password = "min43ad"}
        };
    }
}
