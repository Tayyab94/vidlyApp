namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewCustomerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        BithDate = c.DateTime(),
                        IsSubscribeToNewsletter = c.Boolean(nullable: false),
                        MemberShiptype_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MemberShiptypes", t => t.MemberShiptype_Id)
                .Index(t => t.MemberShiptype_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShiptype_Id", "dbo.MemberShiptypes");
            DropIndex("dbo.Customers", new[] { "MemberShiptype_Id" });
            DropTable("dbo.Customers");
        }
    }
}
