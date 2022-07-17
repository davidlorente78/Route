using Domain;

namespace StaticData.Malaysia
{
    public static class MalaysiaTrainLines
    {

        public static Line WestCoast = new Line
        {
            Name = "KTM West Coast",
            LineType = 'T',
            Branches = new List<Branch> { MalaysiaTrainBranches.KTMWestCoast }
        };


        public static Line EastCoast = new Line
        {
            Name = "KTM East Coast",
            LineType = 'T',
            Branches = new List<Branch> { MalaysiaTrainBranches.KTMEastCoast }

        };

        public static List<Line> GetAll()
        {
             return new List<Line> { WestCoast, EastCoast };
        }
    }
}
