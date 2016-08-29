namespace VSTDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Todoes", "Completed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Completed", c => c.Boolean(nullable: false));
        }
    }
}
