namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.PostContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.PostContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            for(int i = 0; i < 10; i++)
            {
                context.Users.AddOrUpdate(new Models.User
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 5),
                    Uname = "User-" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Type = "User"
                });
            }
        }
    }
}
