using Data;
using Domain.Transport.Railway;

namespace Data.Malaysia
{
    public static class MalaysiaTrainBranches
    {

        public static RailwayBranch KTMWestCoast = new RailwayBranch
        {

            Name = "KTM West Coast Railway Line",
            MainBranch = true,
             Stations = new List<RailwayStation>
            {
                MalaysiaTrainStations.PadangBesar,
                MalaysiaTrainStations.BukitKetri,
                MalaysiaTrainStations.Arau,
                MalaysiaTrainStations.KualaKangsar,
                MalaysiaTrainStations.Ipoh,
                MalaysiaTrainStations.KualaLumpurSentral,
                MalaysiaTrainStations.Gemas,
                MalaysiaTrainStations.JohorBahru,
                MalaysiaTrainStations.WoodlandsTrainCheckpoint

            }

        };


        /// <summary>
        /// https://www.nomadicnotes.com/jungle-railway-malaysia/
        /// </summary>
        public static RailwayBranch KTMEastCoast = new RailwayBranch
        {

            Name = "KTM East Coast Railway Line",
             MainBranch = true,
            Stations = new List<RailwayStation>
            {
               MalaysiaTrainStations.Tumpat,
               MalaysiaTrainStations.KualaKrai,
               MalaysiaTrainStations.Dabong,
               MalaysiaTrainStations.GuaMusang,
               MalaysiaTrainStations.KualaLipis,
               MalaysiaTrainStations.Gemas,
            }
        };
    }
}
