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
        DbSet<Order> Oders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Client> Clients { get; set; }
    }
}
