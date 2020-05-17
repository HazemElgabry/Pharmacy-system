namespace Pharmacy_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMedicineTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Price = c.Int(nullable: false),
                        expire_date = c.String(),
                        description = c.String(),
                        import_date = c.String(),
                        black_list = c.String(),
                        max_dose = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicines");
        }
    }
}
