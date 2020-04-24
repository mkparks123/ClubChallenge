namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBsetclubhours : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberClubHours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClockIn = c.DateTime(),
                        ClockOut = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MemberClubHours");
        }
    }
}
