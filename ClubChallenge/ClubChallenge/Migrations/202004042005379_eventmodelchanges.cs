namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventmodelchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventStartTime", c => c.DateTime());
            AddColumn("dbo.Events", "EventEndTime", c => c.DateTime());
            AddColumn("dbo.Events", "EventTotalTime", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "EventTotalTime");
            DropColumn("dbo.Events", "EventEndTime");
            DropColumn("dbo.Events", "EventStartTime");
        }
    }
}
