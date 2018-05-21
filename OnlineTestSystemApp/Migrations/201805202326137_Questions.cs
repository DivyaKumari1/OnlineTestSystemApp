namespace OnlineTestSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Questions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Questions", "Option1", c => c.Int(nullable: false));
            AlterColumn("dbo.Questions", "Option2", c => c.Int(nullable: false));
            AlterColumn("dbo.Questions", "Option3", c => c.Int(nullable: false));
            AlterColumn("dbo.Questions", "Option4", c => c.Int(nullable: false));
            AlterColumn("dbo.Questions", "CorrectOption", c => c.Int(nullable: false));
            AlterColumn("dbo.Questions", "MarkedOption", c => c.Int(nullable: false));
            AlterColumn("dbo.Questions", "isAnsweredCorrect", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questions", "isAnsweredCorrect", c => c.Boolean());
            AlterColumn("dbo.Questions", "MarkedOption", c => c.String());
            AlterColumn("dbo.Questions", "CorrectOption", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Questions", "Option4", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Questions", "Option3", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Questions", "Option2", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Questions", "Option1", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
