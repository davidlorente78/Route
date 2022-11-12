using Domain;
using Domain.Transport.Railway;

namespace StaticData.Thailand
{
    public static class ThailandTrainLines
    {

        public static RailwayLine SouthernLine = new RailwayLine
        {
            Name = "Southern Line",
            Description = "Thailand’s Southern train line runs a distance of 1,144 kilometres between Hua Lamphong train station in Bangkok and Sungai Kolok train station in the far south of Thailand. Thailand’s Southern train line connects Bangkok with the beach resorts of Cha Am, Hua Hin, Pran Buri, Trang, the island of Koh Tao via Chumphon and the islands of Koh Samui and Koh Phangan via Surat Thani train station.",
            LineType = 'T',
            Branches = new List<RailwayBranch> { ThailandTrainBranches.SouthernLine, ThailandTrainBranches.SouthernLine_KantangBranch, ThailandTrainBranches.SouthernLine_PadangBesar }
        };

        public static RailwayLine NorthernLine = new RailwayLine
        {
            Name = "Northern Line",
            LineType = 'T',
            Branches = new List<RailwayBranch> { ThailandTrainBranches.NorthernLine, ThailandTrainBranches.NorthernLine_Sawankhalok }
        };

        public static RailwayLine NorthEasternLine = new RailwayLine
        {

            Name = "North Eastern Line",
            LineType = 'T',
            Branches = new List<RailwayBranch> { ThailandTrainBranches.NorthEasternLine_BuaYai_ThanonChira, ThailandTrainBranches.NorthEasternLine_UbonRatchathani, ThailandTrainBranches.NorthEasternLineLine_NongKhai }
        };

        public static RailwayLine EasternLine = new RailwayLine
        {

            Name = "Eastern Line",
            LineType = 'T',
            Branches = new List<RailwayBranch> { ThailandTrainBranches.EasternLine_Pattaya, ThailandTrainBranches.EasternLine_Aranyaprathet }
        };

        
        public static ICollection<RailwayLine> GetAll()
        {
            return new List<RailwayLine> { SouthernLine , NorthernLine, NorthEasternLine, EasternLine};
        }
    }
}
