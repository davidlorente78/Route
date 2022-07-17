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

        public string Name { get; set; }
        public string? Description { get; set; }
        public char LineType { get; set; }
        public ICollection<Branch>? Branches { get; set; }
        
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}
