using Domain.Ranges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Vietnam
{
 
        public static class DataVietnam
        {
        public static Country Vietnam = new Country
        {
            Code = 'V',
            Name = "Vietnam",
            Destinations = VietnamDestinations.GetAll(),
            Frontiers = VietnamFrontiers.GetAll(),
            Airports = VietnamAirports.GetAll(),
            TrainLines = VietnamTrainLines.GetAll(),
            Ranges = new List<RangeChar> { VietnamRanges.SeasonRange , VietnamRanges.MonsoonRange },
            ShowInDynamicHome = true,
            ShowInDynamicHomeOrder = 0

            };
        }
    
}
