using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Transport.Aviation
{
    public class AirportType
    {
        public int AirportTypeID { get; set; }
        public char? Code { get; set; }
        public string? Description { get; set; }
    }
}
