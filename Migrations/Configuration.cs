﻿namespace QuanlyCafe.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanlyCafe.EntityFramework.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuanlyCafe.EntityFramework.AppDbContext context)
        {
            context.Accounts.AddOrUpdate(x => x.Id, new EntityFramework.Account()
            {
                Id = 1,
                UserName = "admin",
                Password = "123qwe",
                CreationTime = DateTime.Now,
                DislayName = "admin",
                Status = EntityFramework.Status.Active
            });

            context.AreaTables.AddOrUpdate(x => x.Id, new EntityFramework.AreaTable()
            {
                Id = 1,
                Name = "Khu A",
                CreationTime = DateTime.Now,
                Status = EntityFramework.Status.Active,
                Tables = new System.Collections.Generic.List<EntityFramework.Table>()
                {
                    new EntityFramework.Table()
                    {
                        Id = 1,
                        Name = "Bàn số 1",
                        CreationTime =DateTime.Now,
                        Status = EntityFramework.Status.Active,
                    }
                }
            });

            context.Categories.AddOrUpdate(x => x.Id, new EntityFramework.Category()
            {
                Id = 1,
                Name = "Nước ngọt",
                CreationTime = DateTime.Now,
                Status = EntityFramework.Status.Active,
                Foods = new System.Collections.Generic.List<EntityFramework.Food>()
                {
                    new EntityFramework.Food()
                    {
                        Id = 1,
                        Name = "Pepsi",
                        Price = 10000,
                        CreationTime = DateTime.Now,
                        Status = EntityFramework.Status.Active,
                    }
                }
            });
        }
    }
}
