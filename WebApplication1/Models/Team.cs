using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplication1.Models
{
    

    public class Team
    {
        public Team()
        {
            var Players = new List<Player>();
        }

        public int TeamId { get; set; }
        //Update StudentName to TeamName, add new migration and run seed method.
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        public virtual League League { get; set; }
        //Many to Many Team to Match
        public virtual ICollection<MatchTeam> MatchTeams { get; set; }

    }
}