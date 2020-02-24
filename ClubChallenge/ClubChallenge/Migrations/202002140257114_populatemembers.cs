namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatemembers : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Members (FirstName, LastName) VALUES ('Michael','Parks')");

        }
        
        public override void Down()
        {
        }
    }
}
