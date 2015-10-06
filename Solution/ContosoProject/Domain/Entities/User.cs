using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class User : ExtendedEntity
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Role Role { get; private set; }

        public User(int id, bool isActive, DateTime date, User user, string login, string password, Role role) : base(id, isActive, date, user)
        {
            Login = login;
            Password = password;
            Role = role;
        }

    }
}
