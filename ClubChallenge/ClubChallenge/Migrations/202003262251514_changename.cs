namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberEventDatas", "FirstName", c => c.String());
            DropColumn("dbo.MemberEventDatas", "FristName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberEventDatas", "FristName", c => c.String());
            DropColumn("dbo.MemberEventDatas", "FirstName");
        }
    }
}
