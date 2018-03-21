namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShip : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShiptypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMont = c.Byte(nullable: false),
                        DiscountInRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MemberShiptype_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MemberShiptype_Id");
            AddForeignKey("dbo.Customers", "MemberShiptype_Id", "dbo.MemberShiptypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShiptype_Id", "dbo.MemberShiptypes");
            DropIndex("dbo.Customers", new[] { "MemberShiptype_Id" });
            DropColumn("dbo.Customers", "MemberShiptype_Id");
            DropTable("dbo.MemberShiptypes");
        }
    }
}
