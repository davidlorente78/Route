
using System.Collections.Generic;

namespace Traveller
{
    public class Country
    {
        public char Code;
        public string Name;
        public List<Frontier> Frontiers;
        public List<Destination> Destinations;
        public List<Visa> Visas;

        public Country() { }

       
    }
}
