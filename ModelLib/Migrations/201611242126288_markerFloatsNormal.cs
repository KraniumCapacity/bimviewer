namespace ModelLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class markerFloatsNormal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Markers", "normalX", c => c.Single(nullable: false));
            AddColumn("dbo.Markers", "normalY", c => c.Single(nullable: false));
            AddColumn("dbo.Markers", "normalZ", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Markers", "normalZ");
            DropColumn("dbo.Markers", "normalY");
            DropColumn("dbo.Markers", "normalX");
        }
    }
}
