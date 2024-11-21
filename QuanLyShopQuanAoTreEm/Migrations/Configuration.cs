namespace QuanLyShopQuanAoTreEm.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanLyShopQuanAoTreEm.Models.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "QuanLyShopQuanAoTreEm.Models.ShopContext";
        }

        protected override void Seed(QuanLyShopQuanAoTreEm.Models.ShopContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
