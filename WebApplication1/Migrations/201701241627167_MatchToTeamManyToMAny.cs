namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatchToTeamManyToMAny : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatchTeams",
                c => new
                    {
                        MatchTeamId = c.Int(nullable: false, identity: true),
                        TeamId = c.String(),
                        MatchId = c.String(),
                        Match_MatchId = c.Int(),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.MatchTeamId)
                .ForeignKey("dbo.Matches", t => t.Match_MatchId)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Match_MatchId)
                .Index(t => t.Team_TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MatchTeams", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.MatchTeams", "Match_MatchId", "dbo.Matches");
            DropIndex("dbo.MatchTeams", new[] { "Team_TeamId" });
            DropIndex("dbo.MatchTeams", new[] { "Match_MatchId" });
            DropTable("dbo.MatchTeams");
        }
    }
}
