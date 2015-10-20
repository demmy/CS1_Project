using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFRepository
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.SetInitializer<ProjectContext>(new DropCreateDatabaseAlways<ProjectContext>());
        }

        public DbSet<Order> Oders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
