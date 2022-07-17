using Domain.Ranges;
using StaticData.Thailand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Vietnam
{
 
        public static class DataThailand
        {
        public static Country Thailand = new Country
        {
            Code = 'T',
            Name = "Thailand",
            Visas = new List<Visa> { ThailandVisas.VisaExemption },
            Destinations = ThailandDestinations.GetAll(),
            Frontiers = ThailandFrontiers.GetAll(),
            TrainLines = ThailandTrainLines.GetAll(),
            //Regions
            Ranges = new List<RangeChar> { ThailandRanges.SeasonRange }

        };
    }
    
}
