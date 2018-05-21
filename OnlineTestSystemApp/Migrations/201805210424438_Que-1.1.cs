namespace OnlineTestSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Que11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Questions", "isAnsweredCorrect", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questions", "isAnsweredCorrect", c => c.Boolean(nullable: false));
        }
    }
}
