using Domain;

namespace StaticData.Thailand
{
    public static class ThailandTrainLines
    {

        public static Line SouthernLine = new Line
        {
            Name = "Southern Line",
            Description = "Thailand’s Southern train line runs a distance of 1,144 kilometres between Hua Lamphong train station in Bangkok and Sungai Kolok train station in the far south of Thailand. Thailand’s Southern train line connects Bangkok with the beach resorts of Cha Am, Hua Hin, Pran Buri, Trang, the island of Koh Tao via Chumphon and the islands of Koh Samui and Koh Phangan via Surat Thani train station.",
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
            return new List<Line> { SouthernLine , NorthernLine, NorthEasternLine, EasternLine};
        }
    }
}
