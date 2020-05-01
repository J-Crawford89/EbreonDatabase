namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedspellingonsubclass : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Subclasses");
            DropColumn("dbo.Subclasses", "SublcassId");
            DropColumn("dbo.Subclasses", "SublcassName");
            DropColumn("dbo.Subraces", "AbilityStoreIncrease");
            AddColumn("dbo.Subclasses", "SubclassId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Subclasses", "SubclassName", c => c.String());
            AddColumn("dbo.Subraces", "AbilityScoreIncrease", c => c.String());
            AddPrimaryKey("dbo.Subclasses", "SubclassId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subraces", "AbilityStoreIncrease", c => c.String());
            AddColumn("dbo.Subclasses", "SublcassName", c => c.String());
            AddColumn("dbo.Subclasses", "SublcassId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Subclasses");
            DropColumn("dbo.Subraces", "AbilityScoreIncrease");
            DropColumn("dbo.Subclasses", "SubclassName");
            DropColumn("dbo.Subclasses", "SubclassId");
            AddPrimaryKey("dbo.Subclasses", "SublcassId");
        }
    }
}
