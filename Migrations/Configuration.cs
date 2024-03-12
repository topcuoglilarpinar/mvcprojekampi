namespace MvcPorjekampiEğitimi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcPorjekampiEğitimi.Class.Context>
    {
        public Configuration()
        {
            
            //bu ekranın gelmesi için anable-migration yazılıp çalıştırılmalı bu işlemleri yapıyoruz ki veritanabanına yansıtma işlmei gerçeklştirilsin
            AutomaticMigrationsEnabled = true;
           



        }

        protected override void Seed(MvcPorjekampiEğitimi.Class.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
