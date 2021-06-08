using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller
{
    public class Destination
    {
        public string Code;
        public string Name;
        public char CountryCode;
        public int Days;
        public string Description;

        public char Type { get; internal set; }
    }
}
