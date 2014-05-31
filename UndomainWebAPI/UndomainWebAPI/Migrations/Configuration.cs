namespace UndomainWebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UndomainWebAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UndomainWebAPI.Models.UndomainWebAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UndomainWebAPI.Models.UndomainWebAPIContext context)
        {
            context.Entities.AddOrUpdate(e => e.ValueFamily,
                new Entity
                {
                    ID = 1,
                    ValueFamily = "Customer",
                    Value = "C347186",
                    Type = 0,
                    ParentID = 0
                },
                new Entity
                {
                    ID = 2,
                    ValueFamily = "Name",
                    Value = "Acme Corp",
                    Type = 1,
                    ParentID = 1
                },
                new Entity
                {
                    ID = 3,
                    ValueFamily = "Address Type",
                    Value = "Corp HQ",
                    Type = 1,
                    ParentID = 1
                },
                new Entity
                {
                    ID = 4,
                    ValueFamily = "Address Line 1",
                    Value = "1234 Walnut Ave",
                    Type = 1,
                    ParentID = 1
                });
        }
    }
}
