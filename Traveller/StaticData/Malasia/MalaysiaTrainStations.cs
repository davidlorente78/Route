using Domain;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Malaysia
{
    public class MalaysiaTrainStations
    {

        //KTMWestCoast

        public static Station PadangBesar = new Station
        {
            Type = 'T',
            //Lines = new List<Line> { MalasiaTrainLines.KTMWestCoast },
            ServingDestinations = new List<Destination> { MalaysiaDestinations.PadangPesar, ThailandDestinations.PadangPesar },
            Name = "Padang Besar",
            Remarks = "The station is where the Malaysia and Thai railway services meet, allowing for passengers to transfer between the two railway systems. The customs, immigration and quarantine facilities of both countries are co-located in the station, despite it being completely located within the Malaysian territory, about 200 metres south of the border. There is also a smaller railway station on the Thai side of the border called Padang Besar (Thai) railway station."
        };

        public static Station BukitKetri = new Station
        {
            Type = 'T',
            //Lines = new List<Line> { MalasiaTrainLines.KTMWestCoast },
            Name = "Bukit Ketri"
        };

        public static Station Arau = new Station
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

        public static Station KualaKangsar = new Station
        {
            Type = 'T',
            Name = "Kuala Kangsar",
            ServingDestinations = new List<Destination> { MalaysiaDestinations.KualaKangsar}

        };

        //Sungai Siput
        //Tanjung Rambutan
        //Tasek

        public static Station Ipoh = new Station
        {
            Type = 'T',
            Name = "Ipoh",
            ServingDestinations = new List<Destination> { MalaysiaDestinations.Ipoh }
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

        public static Station KualaLumpur = new Station
        {
            Type = 'T',
            Name = "Kuala Lumpur",
            ServingDestinations = new List<Destination> { MalaysiaDestinations.KualaLumpur }
        };

        public static Station KualaLumpurSentral = new Station
        {
            Type = 'T',
            Name = "Kuala Lumpur Sentral",
            ServingDestinations = new List<Destination> { MalaysiaDestinations.KualaLumpur },
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

        public static Station Gemas = new Station
        {
            Type = 'T',
            Name = "Gemas",
            Remarks = "the station is the meeting point of and the railway junction connecting the West Coast Line (Padang Besar–Singapore) with the East Coast Line (Tumpat–Gemas)"
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

        public static Station JohorBahru = new Station {
            Type = 'T',
            //Lines = new List<Line> { MalasiaTrainLines.KTMWestCoast },
            Name = "Johor Bahru Sentral", 
            Remarks = "" };



        public static Station WoodlandsTrainCheckpoint = new Station {
            Type = 'T',
            //Lines = new List<Line> { MalasiaTrainLines.KTMWestCoast },
            Name = "Woodlands Train Checkpoint",
            ServingDestinations = new List<Destination> { SingaporeDestinations.WoodlandsCheckpoint },
            Remarks = "" };


        //KTMEastCoast

        public static Station Tumpat = new Station
        {
            Type = 'T',
            Name = "Tumpat",         
            Remarks = ""
        };

        public static Station KualaKrai = new Station
        {
            Type = 'T',
            Name = "Kuala Krai",
            Remarks = ""
        };


        public static Station Dabong = new Station
        {
            Type = 'T',
            Name = "Dabong",
            Remarks = ""
        };

        public static Station GuaMusang = new Station
        {
            Type = 'T',
            Name = "Gua Musang",
            Remarks = ""
        };

        public static Station KualaLipis = new Station
        {
            Type = 'T',
            Name = "Kuala Lipis",
            Remarks = ""
        };

        ///

        //Gemas // Junction



    }
}
