using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public virtual Team Team { get; set; }
    }
}