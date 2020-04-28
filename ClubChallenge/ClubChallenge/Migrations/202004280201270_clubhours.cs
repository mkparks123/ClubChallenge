namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clubhours : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MemberClubHours", "ClockIn", c => c.DateTime());
            AlterColumn("dbo.MemberClubHours", "ClockOut", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberClubHours", "ClockOut", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MemberClubHours", "ClockIn", c => c.DateTime(nullable: false));
        }
    }
}
