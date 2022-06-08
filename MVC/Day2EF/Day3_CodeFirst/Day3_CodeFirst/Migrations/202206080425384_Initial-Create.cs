namespace Day3_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblCar",
                c => new
                    {
                        CarNo = c.Int(nullable: false, identity: true),
                        CarName = c.String(),
                        CarType = c.String(),
                        CarCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CarNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblCar");
        }
    }
}
