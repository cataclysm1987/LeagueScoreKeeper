using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Match
    {
        public int MatchId { get; set; }
        public string MatchName { get; set; }

        public virtual League League { get; set; }
    }
}