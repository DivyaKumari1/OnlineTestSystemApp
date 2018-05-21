namespace OnlineTestSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionNumber = c.Int(nullable: false, identity: true),
                        EmailId = c.String(),
                        QuestionText = c.String(nullable: false, maxLength: 500),
                        option1 = c.String(nullable: false, maxLength: 50),
                        option2 = c.String(nullable: false, maxLength: 50),
                        option3 = c.String(nullable: false, maxLength: 50),
                        option4 = c.String(nullable: false, maxLength: 50),
                        correctOption = c.String(nullable: false, maxLength: 50),
                        MarkedOption = c.String(),
                        isAnsweredCorrect = c.Boolean(),
                    })
                .PrimaryKey(t => t.QuestionNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Questions");
        }
    }
}
