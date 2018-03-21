namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeAbcTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Abs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Abs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
