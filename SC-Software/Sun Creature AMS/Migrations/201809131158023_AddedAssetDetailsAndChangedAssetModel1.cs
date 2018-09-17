namespace Sun_Creature_AMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAssetDetailsAndChangedAssetModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AssetDetails", "AssetDescription", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AssetDetails", "AssetDescription", c => c.String());
        }
    }
}
