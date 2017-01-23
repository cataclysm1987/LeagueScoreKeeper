using System.Collections.Generic;
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
        public string TeamName { get; set; }

        public virtual League League { get; set; }

        
    }
}