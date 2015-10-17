using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace ContosoUI.UserSearchForm
{
    interface IUserView
    {
        string Login { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        ICollection<User> UserGrid { get; set; }
    }
}
