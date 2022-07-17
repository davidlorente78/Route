using Domain;

namespace StaticData.Malaysia
{
    public static class MalaysiaTrainBranches
    {

        public static Branch KTMWestCoast = new Branch
        {

            Name = "KTM West Coast Railway Line",
            MainBranch = true,
            Description = "The West Coast railway line runs from Padang Besar railway station close to the Malaysia–Thailand border in Perlis (where it connects with the State Railway of Thailand) to Woodlands Train Checkpoint in Singapore. It is called the West Coast railway line because it serves the West Coast states of Peninsular Malaysia.",
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
            Description = "The East Coast railway line (ECRL) is the single track metre gauge runs between Gemas railway station, in Negeri Sembilan and Tumpat railway station, in Kelantan of Malaysia.",
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
