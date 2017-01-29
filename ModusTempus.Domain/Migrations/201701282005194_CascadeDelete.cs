namespace ModusTempus.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CascadeDelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Activities", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Records", "ActivityId", "dbo.Activities");
            DropForeignKey("dbo.Permissions", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Subscriptions", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Permissions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Subscriptions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Records", "CreatorId", "dbo.Users");
            AddForeignKey("dbo.Activities", "GroupId", "dbo.Groups", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Records", "ActivityId", "dbo.Activities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Permissions", "Group_Id", "dbo.Groups", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Subscriptions", "GroupId", "dbo.Groups", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Permissions", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Subscriptions", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Records", "CreatorId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Records", "CreatorId", "dbo.Users");
            DropForeignKey("dbo.Subscriptions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Permissions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Subscriptions", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Permissions", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Records", "ActivityId", "dbo.Activities");
            DropForeignKey("dbo.Activities", "GroupId", "dbo.Groups");
            AddForeignKey("dbo.Records", "CreatorId", "dbo.Users", "Id");
            AddForeignKey("dbo.Subscriptions", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Permissions", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Subscriptions", "GroupId", "dbo.Groups", "Id");
            AddForeignKey("dbo.Permissions", "Group_Id", "dbo.Groups", "Id");
            AddForeignKey("dbo.Records", "ActivityId", "dbo.Activities", "Id");
            AddForeignKey("dbo.Activities", "GroupId", "dbo.Groups", "Id");
        }
    }
}
