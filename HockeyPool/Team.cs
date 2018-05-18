using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPool
{
    class HockeyTeam
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        // public Venue ven {get; set;}
        public string abbreviation { get; set; }
        public string teamName { get; set; }
        public string locationName { get; set; }
        public string firstYearOfPlay { get; set; }
        // public Division divis {get; set;}
        // public Conference conf {get;set;}
        // public Franchise fran {get;set;}
        public string shortName { get; set; }
        public string officialSiteUrl { get; set; }
        public int franchiseId { get; set; }
        public bool active { get; set; }

        public HockeyTeam() { }

        
    }
}
