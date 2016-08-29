namespace VSTDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IniitalMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Task = c.String(nullable: false),
                        Priority = c.String(nullable: false),
                        Completed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Todoes");
        }
    }
}
