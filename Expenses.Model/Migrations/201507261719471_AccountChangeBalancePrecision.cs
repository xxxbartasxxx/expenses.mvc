namespace Expenses.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountChangeBalancePrecision : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
