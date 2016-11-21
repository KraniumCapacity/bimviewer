namespace BimViewer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marker1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        x = c.Single(nullable: false),
                        y = c.Single(nullable: false),
                        z = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Markers");
        }
    }
}
