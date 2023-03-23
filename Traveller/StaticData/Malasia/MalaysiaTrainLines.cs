using Domain;
using Domain.Transport.Railway;

namespace Data.Malaysia
{
    public static class MalaysiaTrainLines
    {
        public static RailwayLine WestCoast = new RailwayLine
        {
            Name = "KTM West Coast",
            Description = "The West Coast railway line runs from Padang Besar railway station close to the Malaysia–Thailand border in Perlis (where it connects with the State Railway of Thailand) to Woodlands Train Checkpoint in Singapore. It is called the West Coast railway line because it serves the West Coast states of Peninsular Malaysia.",
            LineType = 'T',
            Branches = new List<RailwayBranch> { MalaysiaTrainBranches.KTMWestCoast }
        };

        public static RailwayLine EastCoast = new RailwayLine
        {
            Name = "KTM East Coast",
            Description = "The East Coast railway line (ECRL) is the single track metre gauge runs between Gemas railway station, in Negeri Sembilan and Tumpat railway station, in Kelantan of Malaysia.",
            LineType = 'T',
            Branches = new List<RailwayBranch> { MalaysiaTrainBranches.KTMEastCoast }
        };

        public static List<RailwayLine> GetAll()
        {
             return new List<RailwayLine> { WestCoast, EastCoast };
        }
    }
}
