namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberShipIDAdd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShiptype_Id", "dbo.MemberShiptypes");
            DropIndex("dbo.Customers", new[] { "MemberShiptype_Id" });
            AddColumn("dbo.Customers", "MemberShiptype_Id1", c => c.Byte());
            AlterColumn("dbo.Customers", "MemberShiptype_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MemberShiptype_Id1");
            AddForeignKey("dbo.Customers", "MemberShiptype_Id1", "dbo.MemberShiptypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShiptype_Id1", "dbo.MemberShiptypes");
            DropIndex("dbo.Customers", new[] { "MemberShiptype_Id1" });
            AlterColumn("dbo.Customers", "MemberShiptype_Id", c => c.Byte());
            DropColumn("dbo.Customers", "MemberShiptype_Id1");
            CreateIndex("dbo.Customers", "MemberShiptype_Id");
            AddForeignKey("dbo.Customers", "MemberShiptype_Id", "dbo.MemberShiptypes", "Id");
        }
    }
}
