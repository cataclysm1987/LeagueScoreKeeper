namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamToPlayerOneToMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Wins = c.Int(nullable: false),
                        Losses = c.Int(nullable: false),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Team_TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_TeamId", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Team_TeamId" });
            DropTable("dbo.Players");
        }
    }
}
