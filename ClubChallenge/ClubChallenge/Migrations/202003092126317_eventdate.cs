namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "EventDate");
        }
    }
}
