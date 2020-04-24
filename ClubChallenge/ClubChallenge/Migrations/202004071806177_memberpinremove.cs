namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memberpinremove : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Members", "PIN");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "PIN", c => c.Int(nullable: false));
        }
    }
}
