using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticData.Vietnam
{
    public static class VietnamTrainLines
    {
        
        public static Line NorthSouthLine = new Line
        {
            Name = "Reunification Express",
            Description = "The Hanoi–Ho Chi Minh City line is the primary railway line serving Vietnam. Trains travelling this line are sometimes referred to as the 'Reunification Express'. ",
            LineType = 'T',
            Branches = new List<Branch> { VietnamTrainBranches.NorthSouth }
        };

        //TODO Add Other Lines

        public static ICollection<Line> GetAll()
        {
            return new List<Line> { NorthSouthLine };
        }
    }
}
