namespace Pharmacy_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "fname", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "lname", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "user_name", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "password", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "password", c => c.String());
            AlterColumn("dbo.Admins", "user_name", c => c.String());
            AlterColumn("dbo.Admins", "lname", c => c.String());
            AlterColumn("dbo.Admins", "fname", c => c.String());
        }
    }
}
