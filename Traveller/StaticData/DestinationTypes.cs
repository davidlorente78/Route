using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace StaticData
{
    public static class DestinationTypes
    {

        public static DestinationType Frontier = new DestinationType { Code = 'F', Description = "Frontier" };
        public static DestinationType Tourism = new DestinationType { Code = 'T', Description = "Tourism" };
        public static DestinationType Airport = new DestinationType { Code = 'A', Description = "Airport" };
        public static DestinationType Bus = new DestinationType { Code = 'B', Description = "Bus Station" };
        public static DestinationType Train = new DestinationType { Code = 'R', Description = "Train Station" };
    }
}
