namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "OriginalDateTime", c => c.DateTime());
            DropColumn("dbo.Notifications", "OrigDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifications", "OrigDateTime", c => c.DateTime());
            DropColumn("dbo.Notifications", "OriginalDateTime");
        }
    }
}
