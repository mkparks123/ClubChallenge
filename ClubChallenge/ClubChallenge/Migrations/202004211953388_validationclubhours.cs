namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationclubhours : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MemberClubHours", "Member_Id", "dbo.Members");
            DropIndex("dbo.MemberClubHours", new[] { "Member_Id" });
            AlterColumn("dbo.MemberClubHours", "Member_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.MemberClubHours", "Member_Id");
            AddForeignKey("dbo.MemberClubHours", "Member_Id", "dbo.Members", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberClubHours", "Member_Id", "dbo.Members");
            DropIndex("dbo.MemberClubHours", new[] { "Member_Id" });
            AlterColumn("dbo.MemberClubHours", "Member_Id", c => c.Int());
            CreateIndex("dbo.MemberClubHours", "Member_Id");
            AddForeignKey("dbo.MemberClubHours", "Member_Id", "dbo.Members", "Id");
        }
    }
}
