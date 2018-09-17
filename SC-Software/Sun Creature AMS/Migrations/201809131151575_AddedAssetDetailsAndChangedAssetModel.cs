namespace Sun_Creature_AMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAssetDetailsAndChangedAssetModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetType = c.String(nullable: false, maxLength: 255),
                        AssetDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Assets", "Details_Id", c => c.Int());
            CreateIndex("dbo.Assets", "Details_Id");
            AddForeignKey("dbo.Assets", "Details_Id", "dbo.AssetDetails", "Id");
            DropColumn("dbo.Assets", "AssetType");
            DropColumn("dbo.Assets", "AssetDescription");
            DropColumn("dbo.Assets", "Details_Manufacturer");
            DropColumn("dbo.Assets", "Details_FullAssetName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Assets", "Details_FullAssetName", c => c.String());
            AddColumn("dbo.Assets", "Details_Manufacturer", c => c.String());
            AddColumn("dbo.Assets", "AssetDescription", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Assets", "AssetType", c => c.String(nullable: false, maxLength: 255));
            DropForeignKey("dbo.Assets", "Details_Id", "dbo.AssetDetails");
            DropIndex("dbo.Assets", new[] { "Details_Id" });
            DropColumn("dbo.Assets", "Details_Id");
            DropTable("dbo.AssetDetails");
        }
    }
}
