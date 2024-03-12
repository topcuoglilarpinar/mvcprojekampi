namespace MvcPorjekampiEğitimi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "SILEN_KULLANICI", c => c.Int(nullable: false));
            AddColumn("dbo.Abouts", "SILINDI", c => c.Int(nullable: false));
            AddColumn("dbo.Abouts", "SILINME_TARIHI", c => c.DateTime(nullable: false));
            AddColumn("dbo.Categories", "SILEN_KULLANICI", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "SILINDI", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "SILINME_TARIHI", c => c.DateTime(nullable: false));
            AddColumn("dbo.Headings", "SILEN_KULLANICI", c => c.Int(nullable: false));
            AddColumn("dbo.Headings", "SILINDI", c => c.Int(nullable: false));
            AddColumn("dbo.Headings", "SILINME_TARIHI", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contents", "SILEN_KULLANICI", c => c.Int(nullable: false));
            AddColumn("dbo.Contents", "SILINDI", c => c.Int(nullable: false));
            AddColumn("dbo.Contents", "SILINME_TARIHI", c => c.DateTime(nullable: false));
            AddColumn("dbo.Writers", "SILEN_KULLANICI", c => c.Int(nullable: false));
            AddColumn("dbo.Writers", "SILINDI", c => c.Int(nullable: false));
            AddColumn("dbo.Writers", "SILINME_TARIHI", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "SILINME_TARIHI");
            DropColumn("dbo.Writers", "SILINDI");
            DropColumn("dbo.Writers", "SILEN_KULLANICI");
            DropColumn("dbo.Contents", "SILINME_TARIHI");
            DropColumn("dbo.Contents", "SILINDI");
            DropColumn("dbo.Contents", "SILEN_KULLANICI");
            DropColumn("dbo.Headings", "SILINME_TARIHI");
            DropColumn("dbo.Headings", "SILINDI");
            DropColumn("dbo.Headings", "SILEN_KULLANICI");
            DropColumn("dbo.Categories", "SILINME_TARIHI");
            DropColumn("dbo.Categories", "SILINDI");
            DropColumn("dbo.Categories", "SILEN_KULLANICI");
            DropColumn("dbo.Abouts", "SILINME_TARIHI");
            DropColumn("dbo.Abouts", "SILINDI");
            DropColumn("dbo.Abouts", "SILEN_KULLANICI");
        }
    }
}
