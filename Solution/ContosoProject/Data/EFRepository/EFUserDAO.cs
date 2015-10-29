using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;

namespace Data.EFRepository
{
    public class EFUserDAO: EFExtendedDAO<User>, IUserRepository
    {
        public ICollection<User> GetBy(string login, string firstName, string lastName)
        {
            var result = dbContext.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(login))
                result = result.Where(user => user.Login == login);

            if (!string.IsNullOrWhiteSpace(firstName))
                result = result.Where(user => user.Person.FirstName == firstName);

            if (!string.IsNullOrWhiteSpace(lastName))
                result = result.Where(user => user.Person.LastName == lastName);
            return result.ToList();
        }

        public ICollection<User> GetByRole(Role role)
        {
            return 
                (from user in dbContext.Users
                    where user.Role == role
                        select user)
                            .ToList();
        }
    }
}
