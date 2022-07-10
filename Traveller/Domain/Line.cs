using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace Domain
{
    public class Line
    {
        public int LineID { get; set; }
        public char LineType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Station> MainTrunk { get; set; }
        public ICollection<Line>? BranchLines { get; set; }       


    }



}
