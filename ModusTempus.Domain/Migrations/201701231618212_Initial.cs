namespace ModusTempus.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Start = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Parent_Id = c.Long(),
                        Group_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.Parent_Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Parent_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Group_Id = c.Long(nullable: false),
                        User_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Group_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 40),
                        Password = c.String(nullable: false),
                        Salt = c.String(nullable: false),
                        Administrator = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Activity_Id = c.Long(nullable: false),
                        Creator_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.Activity_Id)
                .ForeignKey("dbo.Users", t => t.Creator_Id)
                .Index(t => t.Activity_Id)
                .Index(t => t.Creator_Id);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        User_Id = c.Long(nullable: false),
                        Group_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Group_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Group_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Records", "Creator_Id", "dbo.Users");
            DropForeignKey("dbo.Records", "Activity_Id", "dbo.Activities");
            DropForeignKey("dbo.Activities", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Permissions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserGroups", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.UserGroups", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Permissions", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Activities", "Parent_Id", "dbo.Activities");
            DropIndex("dbo.UserGroups", new[] { "Group_Id" });
            DropIndex("dbo.UserGroups", new[] { "User_Id" });
            DropIndex("dbo.Records", new[] { "Creator_Id" });
            DropIndex("dbo.Records", new[] { "Activity_Id" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Permissions", new[] { "User_Id" });
            DropIndex("dbo.Permissions", new[] { "Group_Id" });
            DropIndex("dbo.Groups", new[] { "Name" });
            DropIndex("dbo.Activities", new[] { "Group_Id" });
            DropIndex("dbo.Activities", new[] { "Parent_Id" });
            DropTable("dbo.UserGroups");
            DropTable("dbo.Records");
            DropTable("dbo.Users");
            DropTable("dbo.Permissions");
            DropTable("dbo.Groups");
            DropTable("dbo.Activities");
        }
    }
}
