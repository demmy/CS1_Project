namespace Data.Migrations
{
    using Domain.Entities;
    using Domain.Entities.Users;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.EFRepository.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.EFRepository.ProjectContext context)
        {

            // seed first user
            var person = new Person() { FirstName = "John", LastName = "Doe", MiddleName = "Anonim" };
            var role = new Role(){Title="test role", IsActive = true};
            var user = new User() { Login = "test", Password = "pass", Person = person, Role = role, IsActive = true };

            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
