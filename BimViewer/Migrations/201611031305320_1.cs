namespace BimViewer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BIMs", "path", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BIMs", "path");
        }
    }
}
