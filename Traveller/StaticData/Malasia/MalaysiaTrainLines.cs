using Domain;

namespace StaticData.Malaysia
{
    public static class MalaysiaTrainLines
    {

        public static Line WestCoast = new Line
        {
            Name = "KTM West Coast",
            Description = "The West Coast railway line runs from Padang Besar railway station close to the Malaysia–Thailand border in Perlis (where it connects with the State Railway of Thailand) to Woodlands Train Checkpoint in Singapore. It is called the West Coast railway line because it serves the West Coast states of Peninsular Malaysia.",
            LineType = 'T',
            Branches = new List<Branch> { MalaysiaTrainBranches.KTMWestCoast }
        };


        public static Line EastCoast = new Line
        {
            Name = "KTM East Coast",
            Description = "The East Coast railway line (ECRL) is the single track metre gauge runs between Gemas railway station, in Negeri Sembilan and Tumpat railway station, in Kelantan of Malaysia.",
            LineType = 'T',
            Branches = new List<Branch> { MalaysiaTrainBranches.KTMEastCoast }

        };

        public static List<Line> GetAll()
        {
             return new List<Line> { WestCoast, EastCoast };
        }
    }
}
