namespace OnlineTestSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ques12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Questions", "isAnsweredCorrect", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questions", "isAnsweredCorrect", c => c.Boolean());
        }
    }
}
