namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewCustomerTable1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShiptype_Id", "dbo.MemberShiptypes");
            DropIndex("dbo.Customers", new[] { "MemberShiptype_Id" });
            RenameColumn(table: "dbo.Customers", name: "MemberShiptype_Id", newName: "MemberShiptypeId");
            AlterColumn("dbo.Customers", "MemberShiptypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MemberShiptypeId");
            AddForeignKey("dbo.Customers", "MemberShiptypeId", "dbo.MemberShiptypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShiptypeId", "dbo.MemberShiptypes");
            DropIndex("dbo.Customers", new[] { "MemberShiptypeId" });
            AlterColumn("dbo.Customers", "MemberShiptypeId", c => c.Int());
            RenameColumn(table: "dbo.Customers", name: "MemberShiptypeId", newName: "MemberShiptype_Id");
            CreateIndex("dbo.Customers", "MemberShiptype_Id");
            AddForeignKey("dbo.Customers", "MemberShiptype_Id", "dbo.MemberShiptypes", "Id");
        }
    }
}
