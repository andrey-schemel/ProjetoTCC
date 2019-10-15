namespace TCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationTCC1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "Cnpj", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "Street", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "Cep", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "Phone", c => c.String());
            AlterColumn("dbo.Companies", "Email", c => c.String());
            AlterColumn("dbo.Companies", "Cep", c => c.String());
            AlterColumn("dbo.Companies", "Street", c => c.String());
            AlterColumn("dbo.Companies", "City", c => c.String());
            AlterColumn("dbo.Companies", "State", c => c.String());
            AlterColumn("dbo.Companies", "Cnpj", c => c.String());
            AlterColumn("dbo.Companies", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Description", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
        }
    }
}
