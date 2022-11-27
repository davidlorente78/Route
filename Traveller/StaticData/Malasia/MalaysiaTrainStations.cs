using Data;
using Domain.Transport.Railway;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Malaysia
{
    public class MalaysiaTrainStations
    {
        //KTMWestCoast

        public static RailwayStation PadangBesar = new RailwayStation
        {
            Type = 'T',
            //Lines = new List<Line> { MalasiaTrainLines.KTMWestCoast },
            Destinations = new List<Destination> { MalaysiaDestinations.PadangPesar, ThailandDestinations.PadangPesar },
            Name = "Padang Besar",
            Remarks = "The station is where the Malaysia and Thai railway services meet, allowing for passengers to transfer between the two railway systems. The customs, immigration and quarantine facilities of both countries are co-located in the station, despite it being completely located within the Malaysian territory, about 200 metres south of the border. There is also a smaller railway station on the Thai side of the border called Padang Besar (Thai) railway station."
        };

        public static RailwayStation BukitKetri = new RailwayStation
        {
            Type = 'T',
            //Lines = new List<Line> { MalasiaTrainLines.KTMWestCoast },
            Name = "Bukit Ketri"
        };

        public static RailwayStation Arau = new RailwayStation
        {
            Type = 'T',
            Name = "Arau",
        };

        //Kodiang
        //Anak Bukit
        //Alor Setar
        //Kobah
        //Gurun
        //Sungai Petani
        //Tasek Gelugor
        //Simpang Ampat
        //Nibong Tebal
        //Parit Buntar
        //Bagan Serai
        //Kamunting
        //Taiping
        //Padang Rengas

        public static RailwayStation KualaKangsar = new RailwayStation
        {
            Type = 'T',
            Name = "Kuala Kangsar",
            Destinations = new List<Destination> { MalaysiaDestinations.KualaKangsar }
        };

        //Sungai Siput
        //Tanjung Rambutan
        //Tasek

        public static RailwayStation Ipoh = new RailwayStation
        {
            Type = 'T',
            Name = "Ipoh",
            Destinations = new List<Destination> { MalaysiaDestinations.Ipoh }
        };

        //Batu Gajah
        //Kampar
        //Tapah Road
        //Sungkai
        //Slim River
        //Behrang
        //Tanjung Malim
        //Kuala Kubu Bharu
        //Rasa
        //Batang Kali
        //Serendah
        //Rawang
        //Kuang
        //Sungai Buloh
        //Kepong Sentral
        //Kepong
        //Segambut
        //Putra
        //Bank Negara

        public static RailwayStation KualaLumpur = new RailwayStation
        {
            Type = 'T',
            Name = "Kuala Lumpur",
            Destinations = new List<Destination> { MalaysiaDestinations.KualaLumpur }
        };

        public static RailwayStation KualaLumpurSentral = new RailwayStation
        {
            Type = 'T',
            Name = "Kuala Lumpur Sentral",
            Destinations = new List<Destination> { MalaysiaDestinations.KualaLumpur },
            Remarks = "Central interchange with all intercity and commuter trains, rapid transit, monorail and airport rail link"
        };

        //Mid Valley
        //Seputeh
        //Salak Selatan
        //Bandar Tasik Selatan
        //Serdang
        //Kajang
        //UKM
        //Bangi
        //Batang Benar
        //Nilai
        //Labu
        //Tiroi
        //Seremban
        //Senawang
        //Sungai Gadut
        //Rembau
        //Pulau Sebang/Tampin
        //Batang Melaka
        //Air Kuning Selatan

        public static RailwayStation Gemas = new RailwayStation
        {
            Type = 'T',
            Name = "Gemas",
            Remarks = "The station is the meeting point of and the railway junction connecting the West Coast Line (Padang Besar–Singapore) with the East Coast Line (Tumpat–Gemas)"
        };

        //Batu Anam
        //Segamat
        //Tenang
        //Labis
        //Bekok
        //Paloh
        //Chamek
        //Kluang
        //Rengam
        //Layang-Layang
        //Kulai
        //Kempas Baru
        //Danga City Mall

        public static RailwayStation JohorBahru = new RailwayStation
        {
            Type = 'T',
            //Lines = new List<Line> { MalasiaTrainLines.KTMWestCoast },
            Name = "Johor Bahru Sentral",
            Remarks = ""
        };

        public static RailwayStation WoodlandsTrainCheckpoint = new RailwayStation
        {
            Type = 'T',
            //Lines = new List<Line> { MalasiaTrainLines.KTMWestCoast },
            Name = "Woodlands Train Checkpoint",
            Destinations = new List<Destination> { SingaporeDestinations.WoodlandsCheckpoint },
            Remarks = ""
        };

        //KTMEastCoast

        public static RailwayStation Tumpat = new RailwayStation
        {
            Type = 'T',
            Name = "Tumpat",
            Remarks = ""
        };

        public static RailwayStation KualaKrai = new RailwayStation
        {
            Type = 'T',
            Name = "Kuala Krai",
            Remarks = ""
        };

        public static RailwayStation Dabong = new RailwayStation
        {
            Type = 'T',
            Name = "Dabong",
            Remarks = ""
        };

        public static RailwayStation GuaMusang = new RailwayStation
        {
            Type = 'T',
            Name = "Gua Musang",
            Remarks = ""
        };

        public static RailwayStation KualaLipis = new RailwayStation
        {
            Type = 'T',
            Name = "Kuala Lipis",
            Remarks = ""
        };

        ///

        //Gemas // Junction
    }
}
