namespace TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friend",
                c => new
                    {
                        FriendID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FriendID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Timetable",
                c => new
                    {
                        TimetableID = c.Int(nullable: false, identity: true),
                        TimeFrom = c.DateTime(nullable: false),
                        TimeTo = c.DateTime(nullable: false),
                        Discription = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TimetableID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Timetable", "UserID", "dbo.User");
            DropForeignKey("dbo.Friend", "UserID", "dbo.User");
            DropIndex("dbo.Timetable", new[] { "UserID" });
            DropIndex("dbo.Friend", new[] { "UserID" });
            DropTable("dbo.Timetable");
            DropTable("dbo.User");
            DropTable("dbo.Friend");
        }
    }
}
