namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class timespan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "EventStartTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Events", "EventEndTime", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EventEndTime", c => c.DateTime());
            AlterColumn("dbo.Events", "EventStartTime", c => c.DateTime());
        }
    }
}
