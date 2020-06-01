namespace Pharmacy_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modify : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Medicines", "Image", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Medicines", "Image", c => c.String());
        }
    }
}
