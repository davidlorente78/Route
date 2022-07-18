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

        public static Line NorthernLine = new Line
        {
            Name = "Northern Line",
            LineType = 'T',
            Branches = new List<Branch> { ThailandTrainBranches.NorthernLine, ThailandTrainBranches.NorthernLine_Sawankhalok }
        };

        public static Line NorthEasternLine = new Line
        {

            Name = "North Eastern Line",
            LineType = 'T',
            Branches = new List<Branch> { ThailandTrainBranches.NorthEasternLine_BuaYai_ThanonChira, ThailandTrainBranches.NorthEasternLine_UbonRatchathani, ThailandTrainBranches.NorthEasternLineLine_NongKhai }
        };

        public static Line EasternLine = new Line
        {

            Name = "Eastern Line",
            LineType = 'T',
            Branches = new List<Branch> { ThailandTrainBranches.EasternLine_Pattaya, ThailandTrainBranches.EasternLine_Aranyaprathet }
        };

        
        public static ICollection<Line> GetAll()
        {
            return new List<Line> { SouthernLine , NorthernLine, NorthEasternLine};
        }
    }
}
