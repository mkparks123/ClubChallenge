namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membereventdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberEventDatas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FristName = c.String(),
                        LastName = c.String(),
                        EventID = c.Int(nullable: false),
                        Member_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .Index(t => t.Member_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberEventDatas", "Member_Id", "dbo.Members");
            DropIndex("dbo.MemberEventDatas", new[] { "Member_Id" });
            DropTable("dbo.MemberEventDatas");
        }
    }
}
