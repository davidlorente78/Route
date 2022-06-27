using System;
using System.Collections.Generic;

namespace Traveller
{
    public class Frontier
    {
        public Destination Origin;
        public Destination Destination;

        public string Name;
        public string Description;
        public List<Visa> Visas;
        public string Type; //T A

        public bool Transit;
        public string Transport;
        public Destination TransitOrigin;
        public Destination TransitDestination;

        public override string ToString()
        {
            string summmary = "";

            summmary = summmary + Name + Environment.NewLine;
            summmary = summmary + Description + Environment.NewLine;


            summmary = summmary + "Accepted visas in this border : " + Environment.NewLine;
            foreach (Visa visa in Visas)
            {
                summmary = summmary + visa.Name;
            }

            return summmary;
        }
    }
}
