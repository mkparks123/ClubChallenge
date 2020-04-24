namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userPIN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "PIN", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "PIN");
        }
    }
}
