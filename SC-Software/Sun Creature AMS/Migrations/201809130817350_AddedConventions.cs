namespace Sun_Creature_AMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedConventions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Assets", "AssetType", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Assets", "AssetDescription", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Assets", "AssetDescription", c => c.String());
            AlterColumn("dbo.Assets", "AssetType", c => c.String());
        }
    }
}
