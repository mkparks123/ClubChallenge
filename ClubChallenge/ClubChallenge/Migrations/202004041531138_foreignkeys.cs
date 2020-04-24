namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkeys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberEventDatas", "Event_Id", c => c.Int());
            AddColumn("dbo.MemberEventDatas", "Member_Id", c => c.Int());
            CreateIndex("dbo.MemberEventDatas", "Event_Id");
            CreateIndex("dbo.MemberEventDatas", "Member_Id");
            AddForeignKey("dbo.MemberEventDatas", "Event_Id", "dbo.Events", "Id");
            AddForeignKey("dbo.MemberEventDatas", "Member_Id", "dbo.Members", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberEventDatas", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.MemberEventDatas", "Event_Id", "dbo.Events");
            DropIndex("dbo.MemberEventDatas", new[] { "Member_Id" });
            DropIndex("dbo.MemberEventDatas", new[] { "Event_Id" });
            DropColumn("dbo.MemberEventDatas", "Member_Id");
            DropColumn("dbo.MemberEventDatas", "Event_Id");
        }
    }
}
