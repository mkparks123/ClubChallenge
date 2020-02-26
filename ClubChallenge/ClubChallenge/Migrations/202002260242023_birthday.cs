namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class birthday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "Birthdate");
        }
    }
}
