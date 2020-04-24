namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "PIN", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.Members", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "LastName", c => c.String());
            AlterColumn("dbo.Members", "FirstName", c => c.String());
            AlterColumn("dbo.Members", "PIN", c => c.Int(nullable: false));
        }
    }
}
