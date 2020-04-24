namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memberobject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberClubHours", "Member_Id", c => c.Int());
            CreateIndex("dbo.MemberClubHours", "Member_Id");
            AddForeignKey("dbo.MemberClubHours", "Member_Id", "dbo.Members", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberClubHours", "Member_Id", "dbo.Members");
            DropIndex("dbo.MemberClubHours", new[] { "Member_Id" });
            DropColumn("dbo.MemberClubHours", "Member_Id");
        }
    }
}
