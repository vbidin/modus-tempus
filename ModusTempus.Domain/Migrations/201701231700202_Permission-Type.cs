namespace ModusTempus.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PermissionType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "DefaultPermission", c => c.Int(nullable: false));
            AddColumn("dbo.Permissions", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Permissions", "Type");
            DropColumn("dbo.Groups", "DefaultPermission");
        }
    }
}
