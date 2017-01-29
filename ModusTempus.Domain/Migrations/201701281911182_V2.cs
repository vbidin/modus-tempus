namespace ModusTempus.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserGroups", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserGroups", "Group_Id", "dbo.Groups");
            DropIndex("dbo.Groups", new[] { "Name" });
            DropIndex("dbo.UserGroups", new[] { "User_Id" });
            DropIndex("dbo.UserGroups", new[] { "Group_Id" });
            RenameColumn(table: "dbo.Activities", name: "Parent_Id", newName: "ParentId");
            RenameColumn(table: "dbo.Activities", name: "Group_Id", newName: "GroupId");
            RenameColumn(table: "dbo.Records", name: "Activity_Id", newName: "ActivityId");
            RenameColumn(table: "dbo.Records", name: "Creator_Id", newName: "CreatorId");
            RenameIndex(table: "dbo.Activities", name: "IX_Group_Id", newName: "IX_GroupId");
            RenameIndex(table: "dbo.Activities", name: "IX_Parent_Id", newName: "IX_ParentId");
            RenameIndex(table: "dbo.Records", name: "IX_Activity_Id", newName: "IX_ActivityId");
            RenameIndex(table: "dbo.Records", name: "IX_Creator_Id", newName: "IX_CreatorId");
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.Long(nullable: false),
                        GroupId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.GroupId);
            
            AddColumn("dbo.Groups", "DefaultPermission", c => c.Int(nullable: false));
            AddColumn("dbo.Permissions", "Type", c => c.Int(nullable: false));
            AlterColumn("dbo.Activities", "Start", c => c.DateTime());
            DropTable("dbo.UserGroups");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        User_Id = c.Long(nullable: false),
                        Group_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Group_Id });
            
            DropForeignKey("dbo.Subscriptions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Subscriptions", "GroupId", "dbo.Groups");
            DropIndex("dbo.Subscriptions", new[] { "GroupId" });
            DropIndex("dbo.Subscriptions", new[] { "UserId" });
            AlterColumn("dbo.Activities", "Start", c => c.DateTime(nullable: false));
            DropColumn("dbo.Permissions", "Type");
            DropColumn("dbo.Groups", "DefaultPermission");
            DropTable("dbo.Subscriptions");
            RenameIndex(table: "dbo.Records", name: "IX_CreatorId", newName: "IX_Creator_Id");
            RenameIndex(table: "dbo.Records", name: "IX_ActivityId", newName: "IX_Activity_Id");
            RenameIndex(table: "dbo.Activities", name: "IX_ParentId", newName: "IX_Parent_Id");
            RenameIndex(table: "dbo.Activities", name: "IX_GroupId", newName: "IX_Group_Id");
            RenameColumn(table: "dbo.Records", name: "CreatorId", newName: "Creator_Id");
            RenameColumn(table: "dbo.Records", name: "ActivityId", newName: "Activity_Id");
            RenameColumn(table: "dbo.Activities", name: "GroupId", newName: "Group_Id");
            RenameColumn(table: "dbo.Activities", name: "ParentId", newName: "Parent_Id");
            CreateIndex("dbo.UserGroups", "Group_Id");
            CreateIndex("dbo.UserGroups", "User_Id");
            CreateIndex("dbo.Groups", "Name", unique: true);
            AddForeignKey("dbo.UserGroups", "Group_Id", "dbo.Groups", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserGroups", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
