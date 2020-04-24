namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removemembereventdata : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MemberEventDatas", "FirstName");
            DropColumn("dbo.MemberEventDatas", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberEventDatas", "LastName", c => c.String());
            AddColumn("dbo.MemberEventDatas", "FirstName", c => c.String());
        }
    }
}
