using Domain;
using Domain.Transport.Railway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Vietnam
{
    public static class VietnamTrainLines
    {

        public static RailwayLine NorthSouthLine = new RailwayLine
        {
            Name = "Reunification Express",
            Description = "The Hanoi–Ho Chi Minh City line is the primary railway line serving Vietnam. Trains travelling this line are sometimes referred to as the 'Reunification Express'. ",
            LineType = 'T',
            Branches = new List<RailwayBranch> { VietnamTrainBranches.NorthSouth }
        };

        //TODO Add Other Lines
        public static ICollection<RailwayLine> GetAll()
        {
            return new List<RailwayLine> { NorthSouthLine };
        }
    }
}
