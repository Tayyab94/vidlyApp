namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMemberShipId : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MemberShiptype_Id1" });
            DropColumn("dbo.Customers", "MemberShiptype_Id");
            RenameColumn(table: "dbo.Customers", name: "MemberShiptype_Id1", newName: "MemberShiptype_Id");
            AlterColumn("dbo.Customers", "MemberShiptype_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MemberShiptype_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MemberShiptype_Id" });
            AlterColumn("dbo.Customers", "MemberShiptype_Id", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Customers", name: "MemberShiptype_Id", newName: "MemberShiptype_Id1");
            AddColumn("dbo.Customers", "MemberShiptype_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MemberShiptype_Id1");
        }
    }
}
