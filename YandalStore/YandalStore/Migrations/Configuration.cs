namespace YandalStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YandalStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<YandalStore.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(YandalStore.Models.Model1 context)
        {
            context.ManagerTypes.AddOrUpdate(s => s.ID, new ManagerType() { ID = 1, Name = "Admin" });
            context.ManagerTypes.AddOrUpdate(s => s.ID, new ManagerType() { ID = 2, Name = "Moderatör" });
            context.Managers.AddOrUpdate(s => s.ID, new Manager() { ID = 1, Name = "Abdullah", Surname = "Çağış", Mail = "a@hotmail.com", Password = "1234", ManagerType_ID = 1, ProfileImage = "abdullah.png", Status = true, CreationDate = Convert.ToDateTime("26/07/2022") });
            
        }
    }
}
