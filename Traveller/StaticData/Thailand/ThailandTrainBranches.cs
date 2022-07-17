using Domain;

namespace StaticData.Thailand
{
    public static class ThailandTrainBranches
    {

        public static Branch SouthernLine = new Branch
        {

            Name = "Southern Line",
            Description = "Thailand’s Southern train line runs a distance of 1,144 kilometres between Hua Lamphong train station in Bangkok and Sungai Kolok train station in the far south of Thailand. Thailand’s Southern train line connects Bangkok with the beach resorts of Cha Am, Hua Hin, Pran Buri, Trang, the island of Koh Tao via Chumphon and the islands of Koh Samui and Koh Phangan via Surat Thani train station.",
            MainBranch = true,
            Stations = new List<Station>
            {   ThailandTrainStations.BangkokHuaLamphong,
                ThailandTrainStations.Ratchaburi,
                ThailandTrainStations.Chumphon,
                ThailandTrainStations.SuratThani,
                ThailandTrainStations.ThungSongJunction,
                ThailandTrainStations.Phatthalung,
                ThailandTrainStations.HatYaiJunction,
                ThailandTrainStations.Pattani,
                ThailandTrainStations.SungaiKolok

            },
                      
            
        };


       
        public static Branch SouthernLine_KantangBranch = new Branch
        {
            
            Name = "Southern Line Kantang Branch",
            Description = "Southern Line Kantang Branch",
            MainBranch = false,
            Stations = new List<Station>
            {
                ThailandTrainStations.ThungSongJunction,
                ThailandTrainStations.Trang,
                ThailandTrainStations.Kantang,
               
            } 
                      
                   };

        public static Branch SouthernLine_PadangBesar = new Branch
        {
            Name = "Southern Line Padang Besar Branch",
            Description = "Southern Line Padang Besar Branch",
            MainBranch = false,
            Stations = new List<Station>
            {
                ThailandTrainStations.HatYaiJunction,
                ThailandTrainStations.PadangBesar,
          
            }
            ,

        };

        public static ICollection<Branch> GetSoutherLineAllBranches()
        {
            //Branch Lines must be returned here in order to avoid Key message error
            return new List<Branch> { SouthernLine , SouthernLine_KantangBranch , SouthernLine_PadangBesar };
        }
    }
}
