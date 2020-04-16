namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbsetvolunteerevent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VolunteerEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        VEventDate = c.DateTime(nullable: false),
                        VEventStartTime = c.Time(nullable: false, precision: 7),
                        VEventEndTime = c.Time(nullable: false, precision: 7),
                        VEventTotalTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "VolunteerEvents_Id", c => c.Int());
            CreateIndex("dbo.Members", "VolunteerEvents_Id");
            AddForeignKey("dbo.Members", "VolunteerEvents_Id", "dbo.VolunteerEvents", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "VolunteerEvents_Id", "dbo.VolunteerEvents");
            DropIndex("dbo.Members", new[] { "VolunteerEvents_Id" });
            DropColumn("dbo.Members", "VolunteerEvents_Id");
            DropTable("dbo.VolunteerEvents");
        }
    }
}
