using System.Data.Entity;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Users;
using System.Collections.Generic;
using Domain.Entities.Clients;
using Domain.Entities.Comments;

namespace Data.EFRepository
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
            : base("name=ProjectContext")
        {
            System.IO.Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory + "\\Data");
            System.AppDomain.CurrentDomain.SetData("DataDirectory", System.AppDomain.CurrentDomain.BaseDirectory);

            Database.SetInitializer(new DropCreateDatabaseAlways<ProjectContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
