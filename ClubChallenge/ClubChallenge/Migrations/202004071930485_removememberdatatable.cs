namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removememberdatatable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.MemberEventDatas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MemberEventDatas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
