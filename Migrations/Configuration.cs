namespace QuanlyCafe.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFramework.AppDbContext context)
        {
            context.Accounts.AddOrUpdate(x => x.Id, new EntityFramework.Account()
            {
                Id = 1,
                UserName = "admin",
                Password = "123456",
                CreationTime = DateTime.Now,
                DislayName = "admin",
                Status = EntityFramework.Status.Active
            });
        }
    }
}
