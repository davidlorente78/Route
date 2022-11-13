using Domain;
using Domain.Ranges;
using Data.Malaysia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Malaysia
{
 
        public static class DataMalaysia
    {
        public static Country Malaysia = new Country
        {
            Code = 'M',
            Name = "Malaysia",
            Destinations = MalaysiaDestinations.GetAll(),
            Airports = MalaysiaAirports.GetAll(),
            BorderCrossings = MalaysiaBorderCrossings.GetAll(),
            TrainLines = MalaysiaTrainLines.GetAll(),
            Ranges = new List<RangeChar> { MalaysiaRanges.SeasonRange , MalaysiaRanges.MonsoonRange, MalaysiaRanges.MonsoonRangeEvaluator },
            ShowInDynamicHome = true,
            ShowInDynamicHomeOrder = 3,
            Visas = new List<Visa> { MalaysiaVisas.freeVisa_Malaysia, MalaysiaVisas.eVisa_Malaysia}

        };
    }
    
}
