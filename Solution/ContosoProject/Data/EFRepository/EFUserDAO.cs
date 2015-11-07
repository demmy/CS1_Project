using System.Collections.Generic;
using System.Linq;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Users;
using System.Data.Entity;

namespace Data.EFRepository
{
    public class EFUserDAO: EFExtendedDAO<User>, IUserRepository
    {
        public EFUserDAO(ProjectContext context)
            : base(context)
        {

        }
        public new IQueryable<User> GetAll()
        {
            return dbContext.Users.Include(user => user.Role).AsQueryable();
        }
        /// <summary>
        /// Function that gets all users that match all not-empty data
        /// </summary>
        /// <param name="login"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public ICollection<User> GetBy(string login, string firstName, string lastName)
        {
            var result = dbContext.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(login))
                result = result.Where(user => user.Login == login);

            if (!string.IsNullOrWhiteSpace(firstName))
                result = result.Where(user => user.Person.FirstName == firstName);

            if (!string.IsNullOrWhiteSpace(lastName))
                result = result.Where(user => user.Person.LastName == lastName);
            return result.Include(user => user.Role).ToList();
        }
        /// <summary>
        /// Gets all users of the specified role
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public ICollection<User> GetByRole(Role role)
        {
            return 
                (from user in dbContext.Users
                    where user.Role == role
                        select user)
                            .ToList();
        }

        /// <summary>
        /// Gets the user of specified login and password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        public User Authentificate(string login, string passwordHash)
        {
            return dbContext.Users
                .Include(user => user.Role)
                .Include(user => user.Role.Permissions)
                .FirstOrDefault(user => user.Login == login && user.Password == passwordHash);
        }
    }
}
