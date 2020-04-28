namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adminlogin : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Admins", "Birthday");
            DropColumn("dbo.Admins", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "UserName", c => c.String(nullable: false));
            AddColumn("dbo.Admins", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
