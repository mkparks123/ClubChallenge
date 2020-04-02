namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ICOLLECTION : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MemberEventDatas", "Member_Id", "dbo.Members");
            DropIndex("dbo.MemberEventDatas", new[] { "Member_Id" });
            AddColumn("dbo.Events", "MemberEventData_id", c => c.Int());
            AddColumn("dbo.Members", "MemberEventData_id", c => c.Int());
            CreateIndex("dbo.Events", "MemberEventData_id");
            CreateIndex("dbo.Members", "MemberEventData_id");
            AddForeignKey("dbo.Events", "MemberEventData_id", "dbo.MemberEventDatas", "id");
            AddForeignKey("dbo.Members", "MemberEventData_id", "dbo.MemberEventDatas", "id");
            DropColumn("dbo.MemberEventDatas", "EventID");
            DropColumn("dbo.MemberEventDatas", "Member_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberEventDatas", "Member_Id", c => c.Int());
            AddColumn("dbo.MemberEventDatas", "EventID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Members", "MemberEventData_id", "dbo.MemberEventDatas");
            DropForeignKey("dbo.Events", "MemberEventData_id", "dbo.MemberEventDatas");
            DropIndex("dbo.Members", new[] { "MemberEventData_id" });
            DropIndex("dbo.Events", new[] { "MemberEventData_id" });
            DropColumn("dbo.Members", "MemberEventData_id");
            DropColumn("dbo.Events", "MemberEventData_id");
            CreateIndex("dbo.MemberEventDatas", "Member_Id");
            AddForeignKey("dbo.MemberEventDatas", "Member_Id", "dbo.Members", "Id");
        }
    }
}
