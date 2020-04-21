namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class volunteerevents1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "VolunteerEvents_Id", "dbo.VolunteerEvents");
            DropIndex("dbo.Members", new[] { "VolunteerEvents_Id" });
            CreateTable(
                "dbo.VolunteerEventsMembers",
                c => new
                    {
                        VolunteerEvents_Id = c.Int(nullable: false),
                        Member_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VolunteerEvents_Id, t.Member_Id })
                .ForeignKey("dbo.VolunteerEvents", t => t.VolunteerEvents_Id, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.Member_Id, cascadeDelete: true)
                .Index(t => t.VolunteerEvents_Id)
                .Index(t => t.Member_Id);
            
            DropColumn("dbo.Members", "VolunteerEvents_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "VolunteerEvents_Id", c => c.Int());
            DropForeignKey("dbo.VolunteerEventsMembers", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.VolunteerEventsMembers", "VolunteerEvents_Id", "dbo.VolunteerEvents");
            DropIndex("dbo.VolunteerEventsMembers", new[] { "Member_Id" });
            DropIndex("dbo.VolunteerEventsMembers", new[] { "VolunteerEvents_Id" });
            DropTable("dbo.VolunteerEventsMembers");
            CreateIndex("dbo.Members", "VolunteerEvents_Id");
            AddForeignKey("dbo.Members", "VolunteerEvents_Id", "dbo.VolunteerEvents", "Id");
        }
    }
}
