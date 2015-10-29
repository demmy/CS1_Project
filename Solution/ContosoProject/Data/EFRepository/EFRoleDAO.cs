using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.EFRepository
{
    public class EFRoleDAO:EFBaseDao<Role>, IRoleRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public ICollection<Role> GetByTitle(string title)
        {
            return (from role in dbContext.Set<Role>()
                        where role.Title == title
                            select role)
                            .ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public ICollection<Role> GetByPermission(Permission permission)
        {
            return (from user in dbContext.Users 
                        where user.Role.Permissions.Contains(permission)
                            select user.Role)
                            .Distinct()
                            .ToList();
        }
    }
}
