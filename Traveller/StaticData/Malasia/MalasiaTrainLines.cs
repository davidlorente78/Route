using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticData.Malasia
{
    public static class MalasiaTrainLines
    {

        public static Line KTMWestCoast = new Line
        {
              
            Name = "KTM West Coast Railway Line",
            Description = "The West Coast railway line runs from Padang Besar railway station close to the Malaysia–Thailand border in Perlis (where it connects with the State Railway of Thailand) to Woodlands Train Checkpoint in Singapore. It is called the West Coast railway line because it serves the West Coast states of Peninsular Malaysia.",
            LineType = 'T',
            MainTrunk = new List<Station>
            {
                MalasiaTrainStations.PadangBesar,
                MalasiaTrainStations.BukitKetri,
                MalasiaTrainStations.Arau,
                MalasiaTrainStations.KualaKangsar,
                MalasiaTrainStations.Ipoh,
                MalasiaTrainStations.KualaLumpurSentral,
                MalasiaTrainStations.Gemas,
                MalasiaTrainStations.JohorBahru,
                MalasiaTrainStations.WoodlandsTrainCheckpoint

            }
            



        };


        /// <summary>
        /// https://www.nomadicnotes.com/jungle-railway-malaysia/
        /// </summary>
        public static Line KTMEastCoast = new Line        {

            Name = "KTM East Coast Railway Line",
            Description = "The East Coast railway line (ECRL) is the single track metre gauge runs between Gemas railway station, in Negeri Sembilan and Tumpat railway station, in Kelantan of Malaysia.",
            LineType = 'T',
            MainTrunk = new List<Station>
            {
               MalasiaTrainStations.Tumpat,
               MalasiaTrainStations.KualaKrai,
               MalasiaTrainStations.Dabong,
               MalasiaTrainStations.GuaMusang,
               MalasiaTrainStations.KualaLipis,
               MalasiaTrainStations.Gemas,
            }
        };

        public static ICollection<Line> GetAll()
        {
            return new List<Line> { KTMWestCoast, KTMEastCoast };
        }
    }
}
