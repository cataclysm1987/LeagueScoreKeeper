namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamToLeagueOneToMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        LeagueId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LeagueId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        League_LeagueId = c.Int(),
                    })
                .PrimaryKey(t => t.TeamId)
                .ForeignKey("dbo.Leagues", t => t.League_LeagueId)
                .Index(t => t.League_LeagueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "League_LeagueId", "dbo.Leagues");
            DropIndex("dbo.Teams", new[] { "League_LeagueId" });
            DropTable("dbo.Teams");
            DropTable("dbo.Leagues");
        }
    }
}
