using Domain.Ranges;
using Data.Thailand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Thailand
{
 
        public static class DataThailand
        {
        public static Country Thailand = new Country
        {
            Code = 'T',
            Name = "Thailand",
            //Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
            Destinations = ThailandDestinations.GetAll(),
            BorderCrossings = ThailandBorderCrossings.GetAll(),
            TrainLines = ThailandTrainLines.GetAll(),
            Airports = ThailandAirports.GetAll(),
            Ranges = new List<RangeChar> { ThailandRanges.SeasonRange , ThailandRanges.MonsoonRange , ThailandRanges.MonsoonRangeEvaluator },
            ShowInDynamicHome = true,
            ShowInDynamicHomeOrder = 5

        };
    }
    
}
