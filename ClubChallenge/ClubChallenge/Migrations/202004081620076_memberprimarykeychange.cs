namespace ClubChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memberprimarykeychange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MemberEvents", "Member_Id", "dbo.Members");
            RenameColumn(table: "dbo.MemberEvents", name: "Member_Id", newName: "Member_MemberId");
            RenameIndex(table: "dbo.MemberEvents", name: "IX_Member_Id", newName: "IX_Member_MemberId");
            DropPrimaryKey("dbo.Members");
            AddColumn("dbo.Members", "MemberId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Members", "PIN", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.Members", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "LastName", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Members", "MemberId");
            AddForeignKey("dbo.MemberEvents", "Member_MemberId", "dbo.Members", "MemberId", cascadeDelete: true);
            DropColumn("dbo.Members", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.MemberEvents", "Member_MemberId", "dbo.Members");
            DropPrimaryKey("dbo.Members");
            AlterColumn("dbo.Members", "LastName", c => c.String());
            AlterColumn("dbo.Members", "FirstName", c => c.String());
            AlterColumn("dbo.Members", "PIN", c => c.Int(nullable: false));
            DropColumn("dbo.Members", "MemberId");
            AddPrimaryKey("dbo.Members", "Id");
            RenameIndex(table: "dbo.MemberEvents", name: "IX_Member_MemberId", newName: "IX_Member_Id");
            RenameColumn(table: "dbo.MemberEvents", name: "Member_MemberId", newName: "Member_Id");
            AddForeignKey("dbo.MemberEvents", "Member_Id", "dbo.Members", "Id", cascadeDelete: true);
        }
    }
}
