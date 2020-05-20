namespace Pharmacy_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "fname", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "lname", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "user_name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "phone_number", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "email_address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "email_address", c => c.String());
            AlterColumn("dbo.Customers", "phone_number", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "password", c => c.String());
            AlterColumn("dbo.Customers", "user_name", c => c.String());
            AlterColumn("dbo.Customers", "lname", c => c.String());
            AlterColumn("dbo.Customers", "fname", c => c.String());
        }
    }
}
