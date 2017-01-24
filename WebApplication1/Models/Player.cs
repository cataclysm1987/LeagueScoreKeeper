using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Display(Name = "Player Name")]
        public string Name { get; set; }
        [Display(Name = "Wins")]
        public int Wins { get; set; }
        [Display(Name = "Losses")]
        public int Losses { get; set; }

        public virtual Team Team { get; set; }
    }
}