using Domain;

namespace StaticData.Thailand
{
    public static class ThailandTrainLines
    {

        public static Line SouthernLine = new Line
        {
            Name = "Southern Line",
            LineType = 'T',
            Branches = new List<Branch> { ThailandTrainBranches.SouthernLine, ThailandTrainBranches.SouthernLine_KantangBranch, ThailandTrainBranches.SouthernLine_PadangBesar }
        };


        public static List<Line> Lines = new List<Line> { SouthernLine };

        public static ICollection<Line> GetAll()
        {
            return new List<Line> { SouthernLine };
        }
    }
}
