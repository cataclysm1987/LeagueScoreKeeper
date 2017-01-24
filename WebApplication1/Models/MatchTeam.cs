using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class MatchTeam
    {
        [Key]
        public int MatchTeamId { get; set; }
        public virtual string TeamId { get; set; }
        public virtual string MatchId { get; set; }
        public virtual Team Team { get; set; }
        public virtual Match Match { get; set; }
    }
}