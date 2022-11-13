using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Nationalities
{
    public static class Nationalities
    {

        public static Nationality ES = new Nationality
        { 
              Code = "ES",
              Description ="Spain"                
        };

        public static Nationality CN = new Nationality
        {
            Code = "CN",
            Description = "China"
        };


    }
}
