using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;

namespace Data.EFRepository
{
    public class EFUserDAO: EFExtendedDAO<User>, IUserRepository
    {
        public ICollection<User> GetBy(string login, Person person)
        {
            var result = dbContext.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(login))
                result = result.Where(user => user.Login == login);

            if (!string.IsNullOrWhiteSpace(person.FirstName))
                result = result.Where(user => user.Person.FirstName == person.FirstName);

            if (!string.IsNullOrWhiteSpace(person.MiddleName))
                result = result.Where(user => user.Person.MiddleName == person.MiddleName);

            if (!string.IsNullOrWhiteSpace(person.LastName))
                result = result.Where(user => user.Person.LastName == person.LastName);
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
