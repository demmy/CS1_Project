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
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            if (!System.IO.Directory.Exists(path + "\\Data"))
                System.IO.Directory.CreateDirectory(path + "\\Data");
            System.AppDomain.CurrentDomain.SetData("DataDirectory", path);

            Database.SetInitializer(new CreateDatabaseIfNotExists<ProjectContext>());
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
