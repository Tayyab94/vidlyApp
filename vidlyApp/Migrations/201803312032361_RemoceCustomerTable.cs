namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoceCustomerTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShiptypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        BithDate = c.DateTime(),
                        IsSubscribeToNewsletter = c.Boolean(nullable: false),
                        MemberShipTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Customers", "MemberShipTypeId");
            AddForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShiptypes", "Id", cascadeDelete: true);
        }
    }
}
