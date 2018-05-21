namespace OnlineTestSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Questionset : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "CreatedDate");
        }
    }
}
