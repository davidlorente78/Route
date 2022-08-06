using Domain;

namespace StaticData.Malaysia
{
    public static class MalaysiaTrainBranches
    {

        public static Branch KTMWestCoast = new Branch
        {

            Name = "KTM West Coast Railway Line",
            MainBranch = true,
             Stations = new List<Station>
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
        public static Branch KTMEastCoast = new Branch
        {

            Name = "KTM East Coast Railway Line",
             MainBranch = true,
            Stations = new List<Station>
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
