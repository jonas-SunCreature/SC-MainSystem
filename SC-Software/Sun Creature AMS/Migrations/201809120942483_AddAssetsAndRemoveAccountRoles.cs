namespace Sun_Creature_AMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAssetsAndRemoveAccountRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetType = c.String(),
                        AssetDescription = c.String(),
                        Quantity = c.Int(nullable: false),
                        Available = c.Boolean(nullable: false),
                        Details_Manufacturer = c.String(),
                        Details_FullAssetName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Assets");
        }
    }
}
