namespace ModusTempus.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Permissions : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Permissions", name: "Group_Id", newName: "GroupId");
            RenameColumn(table: "dbo.Permissions", name: "User_Id", newName: "UserId");
            RenameIndex(table: "dbo.Permissions", name: "IX_User_Id", newName: "IX_UserId");
            RenameIndex(table: "dbo.Permissions", name: "IX_Group_Id", newName: "IX_GroupId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Permissions", name: "IX_GroupId", newName: "IX_Group_Id");
            RenameIndex(table: "dbo.Permissions", name: "IX_UserId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Permissions", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.Permissions", name: "GroupId", newName: "Group_Id");
        }
    }
}
