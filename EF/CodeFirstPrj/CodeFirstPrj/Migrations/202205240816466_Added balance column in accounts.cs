namespace CodeFirstPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedbalancecolumninaccounts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "AccountBalance", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "AccountBalance");
        }
    }
}
