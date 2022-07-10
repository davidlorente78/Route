using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace Domain
{
   
        public class Station
        {
            public int StationID { get; set; }
            public string Name { get; set; }

            //public ICollection<Line>? Lines { get; set; }

            public char Type { get; set; }  // T B

            /// <summary>
            /// The West Coast railway line runs from Padang Besar railway station close to the Malaysia–Thailand border in Perlis (where it connects with the State Railway of Thailand) to Woodlands Train Checkpoint in Singapore. It is called the West Coast railway line because it serves the West Coast states of Peninsular Malaysia.
            /// </summary>
            public string? Remarks { get; set; }
            public ICollection<Destination>? ServingDestinations { get; set; }
            public ICollection<Destination>? MajorLandmarks { get; set; }
            public ICollection<Destination>? InterchangeStations { get; set; }


        }
    
}
