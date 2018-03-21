namespace vidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShiptypes (Id,SignUpFee,DurationInMont,DiscountInRate) VALUES(1,0,0,0)");
            Sql("INSERT INTO MemberShiptypes (Id,SignUpFee,DurationInMont,DiscountInRate) VALUES(2,30,1,10)");
            Sql("INSERT INTO MemberShiptypes (Id,SignUpFee,DurationInMont,DiscountInRate) VALUES(3,90,30,15)");
            Sql("INSERT INTO MemberShiptypes (Id,SignUpFee,DurationInMont,DiscountInRate) VALUES(4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
