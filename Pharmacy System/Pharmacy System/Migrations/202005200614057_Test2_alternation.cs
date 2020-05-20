namespace Pharmacy_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test2_alternation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "phone_number", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Admins", "email_address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "email_address", c => c.String());
            AlterColumn("dbo.Admins", "phone_number", c => c.Int(nullable: false));
        }
    }
}
