using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Match
    {
        [Key]
        [Display(Name = "Match ID")]
        public int MatchId { get; set; }
        [Display(Name = "Match Name")]
        public string MatchName { get; set; }

        public virtual League League { get; set; }

        //Many to Many Match with Team
        public virtual ICollection<MatchTeam> MatchTeams { get; set; }
    }
}