namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _event : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MemberEventDatas", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.Events", "Member_Id", "dbo.Members");
            DropIndex("dbo.Events", new[] { "Member_Id" });
            DropIndex("dbo.MemberEventDatas", new[] { "Event_Id" });
            CreateTable(
                "dbo.MemberEvents",
                c => new
                    {
                        Member_Id = c.Int(nullable: false),
                        Event_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Member_Id, t.Event_Id })
                .ForeignKey("dbo.Members", t => t.Member_Id, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_Id, cascadeDelete: true)
                .Index(t => t.Member_Id)
                .Index(t => t.Event_Id);
            
            DropColumn("dbo.Events", "Member_Id");
            DropColumn("dbo.MemberEventDatas", "Event_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberEventDatas", "Event_Id", c => c.Int());
            AddColumn("dbo.Events", "Member_Id", c => c.Int());
            DropForeignKey("dbo.MemberEvents", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.MemberEvents", "Member_Id", "dbo.Members");
            DropIndex("dbo.MemberEvents", new[] { "Event_Id" });
            DropIndex("dbo.MemberEvents", new[] { "Member_Id" });
            DropTable("dbo.MemberEvents");
            CreateIndex("dbo.MemberEventDatas", "Event_Id");
            CreateIndex("dbo.Events", "Member_Id");
            AddForeignKey("dbo.Events", "Member_Id", "dbo.Members", "Id");
            AddForeignKey("dbo.MemberEventDatas", "Event_Id", "dbo.Events", "Id");
        }
    }
}
