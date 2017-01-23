using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{

    public class League
    {
        public League()
        {
            var Teams = new List<Team>();
            var Matches = new List<Match>();
        }

        [Key]
        public int LeagueId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Match> Matches { get; set; }

    }
}