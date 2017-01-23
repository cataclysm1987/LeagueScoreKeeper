namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTeamName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "TeamName", c => c.String());
            DropColumn("dbo.Teams", "StudentName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "StudentName", c => c.String());
            DropColumn("dbo.Teams", "TeamName");
        }
    }
}
