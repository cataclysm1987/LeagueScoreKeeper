namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LeaguetoMatchOneToMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        MatchId = c.Int(nullable: false, identity: true),
                        MatchName = c.String(),
                        League_LeagueId = c.Int(),
                    })
                .PrimaryKey(t => t.MatchId)
                .ForeignKey("dbo.Leagues", t => t.League_LeagueId)
                .Index(t => t.League_LeagueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "League_LeagueId", "dbo.Leagues");
            DropIndex("dbo.Matches", new[] { "League_LeagueId" });
            DropTable("dbo.Matches");
        }
    }
}
