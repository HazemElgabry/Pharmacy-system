namespace Pharmacy_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAdminTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fname = c.String(),
                        lname = c.String(),
                        user_name = c.String(),
                        password = c.String(),
                        phone_number = c.Int(nullable: false),
                        date_birth = c.String(),
                        email_address = c.String(),
                        card_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
