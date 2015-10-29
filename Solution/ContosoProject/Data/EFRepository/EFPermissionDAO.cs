using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities.Users;

namespace Data.EFRepository
{
    public class EFPermissionDAO: IPermissionRepository
    {
        ProjectContext dbContext = new ProjectContext();
        public ICollection<Permission> GetByTitle(string title)
        {
            return (from user in dbContext.Users 
            //where user.Role.Permissions.Any(permission => permission.Title == title)
                        from permission in user.Role.Permissions
                            where permission.Title == title
                                select permission)
                                .Distinct()
                                .ToList();
        }
    }
}
