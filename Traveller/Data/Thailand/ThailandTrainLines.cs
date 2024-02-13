using Domain.Transport.Railway;

namespace Data.Thailand
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
            Description = "The Northern Line runs alongside the Northeastern Line until the Ban Phachi Junction. There, it splits from the Northeastern Line and proceeds through Lopburi, Nakhon Sawan, Phichit, Phitsanulok, Denchai, Lampang, Lamphun, before finally reaching Chiang Mai, 751 km (467 mi) from Bangkok. There is also a branch off the mainline from Ban Dara Junction to Sawankhalok in Sukhothai Province.",
            LineType = 'T',
            Branches = new List<RailwayBranch> { ThailandTrainBranches.NorthernLine, ThailandTrainBranches.NorthernLine_Sawankhalok }

        };

        public static RailwayLine NorthEasternLine = new RailwayLine
        {
            Name = "North Eastern Line",
            Description= "The Northeastern Line begins on the same route as the Northern Line, splitting at Ban Phachi Junction towards Nakhon Ratchasima. Then at Thanon Chira Junction, the line splits with one route passing Khon Kaen and Udon Thani before terminating at Nong Khai 624 kilometers (388 mi) from Bangkok. The other route passes through Buriram, Surin, Sisaket to reach Ubon Ratchathani, 575 km (357 mi) from Bangkok. There is also another branch route originating from Kaeng Khoi Junction in Saraburi Province passing through Chai Badan District in Lopburi Province and Chatturat District in Chaiyaphum Province, before joining the mainline heading towards Nong Khai at Bua Yai Junction in Nakhon Ratchasima Province.",
            LineType = 'T',
            Branches = new List<RailwayBranch> { ThailandTrainBranches.NorthEasternLine_BuaYai_ThanonChira, ThailandTrainBranches.NorthEasternLine_UbonRatchathani, ThailandTrainBranches.NorthEasternLineLine_NongKhai }
        };

        public static RailwayLine EasternLine = new RailwayLine
        {
            Name = "Eastern Line",
            Description = "The Eastern Line begins at Bangkok before heading through Chachoengsao, Prachinburi to terminate at Aranyaprathet in Sa Kaew Province, 255 kilometers from Bangkok. There is a reopened rail link to Cambodia from Aranyaprathet. A branch line also connects Khlong Sip Kao Junction to the Northeastern Line at Kaeng Khoi Junction. At Chachoengsao Junction, there is another branch to Sattahip. Along the route to Sattahip, at Si Racha Junction, there is yet another branch towards Laem Chabang Deep Sea Port and further at Khao Chi Chan Junction for Map Ta Phut Port, in Rayong.",
            LineType = 'T',
            Branches = new List<RailwayBranch> { ThailandTrainBranches.EasternLine_Pattaya, ThailandTrainBranches.EasternLine_Aranyaprathet }
        };

        public static ICollection<RailwayLine> GetAll()
        {
            return new List<RailwayLine> { SouthernLine, NorthernLine, NorthEasternLine, EasternLine };
        }
    }
}
