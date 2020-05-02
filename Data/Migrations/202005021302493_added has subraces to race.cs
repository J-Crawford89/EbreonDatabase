namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedhassubracestorace : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Races", "HasSubraces", c => c.Boolean(nullable: false));
            AddColumn("dbo.Races", "HasDarkvision", c => c.Boolean(nullable: false));
            DropColumn("dbo.Races", "Darkvision");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Races", "Darkvision", c => c.Boolean(nullable: false));
            DropColumn("dbo.Races", "HasDarkvision");
            DropColumn("dbo.Races", "HasSubraces");
        }
    }
}
