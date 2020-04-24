namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "EventDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EventDate", c => c.DateTime());
            AlterColumn("dbo.Events", "Name", c => c.String());
        }
    }
}
