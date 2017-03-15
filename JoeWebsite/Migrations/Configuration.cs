///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: Configuration.cs
////
//// Date Created: 12/17/2016
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 03/14/2016     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using System.Data.Entity.Migrations;

namespace JoeWebsite.Migrations
{
    /// <summary> Used to configure migration
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<JoeWebsite.Models.ApplicationDbContext>
    {
        /// <summary> Constructor
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary> Used to add test data after a migration is commited
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(JoeWebsite.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}