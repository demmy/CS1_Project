﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Users;

namespace Domain.DAO
{
    public interface IUserRepository : IRepositoryExtension<User>
    {
        ICollection<User> GetBy(string login, string firstName, string lastName);
    }
}
