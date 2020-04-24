namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membermodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MemberEventDatas", "Member_Id", "dbo.Members");
            DropIndex("dbo.MemberEventDatas", new[] { "Member_Id" });
            AddColumn("dbo.Events", "Member_Id", c => c.Int());
            CreateIndex("dbo.Events", "Member_Id");
            AddForeignKey("dbo.Events", "Member_Id", "dbo.Members", "Id");
            DropColumn("dbo.MemberEventDatas", "Member_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberEventDatas", "Member_Id", c => c.Int());
            DropForeignKey("dbo.Events", "Member_Id", "dbo.Members");
            DropIndex("dbo.Events", new[] { "Member_Id" });
            DropColumn("dbo.Events", "Member_Id");
            CreateIndex("dbo.MemberEventDatas", "Member_Id");
            AddForeignKey("dbo.MemberEventDatas", "Member_Id", "dbo.Members", "Id");
        }
    }
}
