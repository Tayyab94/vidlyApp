namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameIntoMemeberShip : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShiptypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShiptypes", "Name");
        }
    }
}
