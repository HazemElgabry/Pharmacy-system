namespace Pharmacy_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false),
                        img = c.String(nullable: false),
                        description = c.String(),
                        release_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
        }
    }
}
