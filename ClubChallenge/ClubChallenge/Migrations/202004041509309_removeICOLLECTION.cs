namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeICOLLECTION : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "MemberEventData_id", "dbo.MemberEventDatas");
            DropForeignKey("dbo.Members", "MemberEventData_id", "dbo.MemberEventDatas");
            DropIndex("dbo.Events", new[] { "MemberEventData_id" });
            DropIndex("dbo.Members", new[] { "MemberEventData_id" });
            DropColumn("dbo.Events", "MemberEventData_id");
            DropColumn("dbo.Members", "MemberEventData_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "MemberEventData_id", c => c.Int());
            AddColumn("dbo.Events", "MemberEventData_id", c => c.Int());
            CreateIndex("dbo.Members", "MemberEventData_id");
            CreateIndex("dbo.Events", "MemberEventData_id");
            AddForeignKey("dbo.Members", "MemberEventData_id", "dbo.MemberEventDatas", "id");
            AddForeignKey("dbo.Events", "MemberEventData_id", "dbo.MemberEventDatas", "id");
        }
    }
}
