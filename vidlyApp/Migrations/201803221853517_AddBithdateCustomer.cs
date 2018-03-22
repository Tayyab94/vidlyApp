namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBithdateCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BithDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BithDate");
        }
    }
}
