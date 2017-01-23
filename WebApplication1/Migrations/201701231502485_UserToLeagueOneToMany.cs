namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserToLeagueOneToMany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Leagues", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Leagues", "ApplicationUser_Id");
            AddForeignKey("dbo.Leagues", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Leagues", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Leagues", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Leagues", "ApplicationUser_Id");
        }
    }
}
