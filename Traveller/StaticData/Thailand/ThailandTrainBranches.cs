﻿using Domain;

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

        public static Branch NorthernLine= new Branch
        {
            Name = "Northern Line",
            Description = "Northern Line",
            MainBranch = true,
            Stations = new List<Station>
            {

                ThailandTrainStations.BangkokHuaLamphong,
                //Yommarat
                //Ho Prajae Chit Lada
                //Ramathibodi Hospital
                //Sam Sen
                //Bang Sue Junction
                //Nikhom Rotfai KM. 11
                //Bang Khen
                //Thung Song Hong
                //Lak Si
                //Kan Keha KM. 19
                //Don Mueang
                //Rangsit
                //Khlong Nueng
                //Chiang Rak
                //Thammasat University
                //Nava Nakhon
                //Chiang Rak Noi
                //Khlong Phutsa
                //Bang Pa-In
                //Ban Pho
                ThailandTrainStations.Ayutthaya,
                //Ban Ma
                //Map Phra Chan
                //Ban Don Klang
                //Phra Kaeo
                //Ban Phachi Junction
                ThailandTrainStations.BanPhachiJunction,
                //Don Ya Nang
                //Nong Wiwat
                //Ban Plak Raet
                //Tha Ruea
                //Ban Mo
                //Nong Don
                //Ban Klap
                //Ban Pa Wai
                ThailandTrainStations.LopBuri,
                //Tha Khae
                //Khok Kathiam
                //Nong Tao
                //Nong Sai Khao
                //Ban Mi
                //Huai Kaeo
                //Phai Yai
                //Rong Rien Chansen
                //Chansen
                //Ban Kok Kwaow
                //Chong Khae
                //Thale Wa
                //Phon Thong
                //Ban Takhli
                //Dong Maku
                //Hua Wai
                //Nong Pho
                //Hua Ngiu
                //Noen Makok
                //Khao Thong
                //Nakhon Sawan
                //Pak Nam Pho
                //Bueng Boraphet
                //Thap Krit
                //Khlong Pla Kot
                //Chumsaeng
                //Wang Krang
                //Bang Mun Nak
                //Ho Krai
                //Dong Takhop
                //Taphan Hin
                //Huai Ket
                //Hua Dong
                //Wang Krot
                //Phichit
                //Tha Lo
                //Bang Krathum
                //Mae Thiap
                //Ban Mai
                //Bueng Phra
                ThailandTrainStations.Phitsanulok,
                //Ban Teng Nam
                //Ban Tum
                //Khwae Noi
                //Phrom Phiram
                //Nong Tom
                //Ban Bung
                //Ban Khon
                //Phichai
                //Rai Oi

                ThailandTrainStations.BanDaraJunction,
                //Tha Sak
                //Tron
                //Wang Kaphi
                //Uttaradit
                //Sila At
                //Tha Sao
                //Ban Dan
                //Pang Ton Phueng
                //Pang Tub Khob Tunnel length 102.09 m (513.72-513.84)
                //Khao Phlueng Tunnel length 362.44 m (516.41-516.77)
                //Khao Phlung
                //Huai Rai
                //Rai Kled Dao
                //Mae Phuak
                //Den Chai
                //Pak Pan
                //Kaeng Luang
                //Huai Mae Ta
                //Ban Pin
                //Huai Mae Lan Tunnel length 130.20 m (574.04-574.17)
                //Pha Khan
                //Pha Kho
                //Pang Puai
                //Mae Chang
                //Mae Mo
                //Huai Rak Mai
                //Sala Pha Lat
                //Mae Tha
                //Nong Wua Thao
                //Nakhon Lampang
                //Hang Chat
                //Pang Muang
                //Huai Rian
                //Mae Tan Noi
                //Khun Tan Tunnel length 1352.10 m (681.57-682.93)
                //Khun Tan
                //Tha Chomphu
                //Sala Mae Tha
                //Nong Lom
                ThailandTrainStations.Lamphun,
                //Pa Sao
                //Saraphi
                ThailandTrainStations.ChiangMai




            }
         ,

        };

        public static Branch NorthernLine_Sawankhalok = new Branch
        {
            Name = "Northern Line Sawan Khalok Branch",
            Description = "Northern Line Sawan Khalok Branch",
            MainBranch = false,
            Stations = new List<Station>
            {
                ThailandTrainStations.BanDaraJunction,
                ThailandTrainStations.KhlongMaphlap,
                ThailandTrainStations.SawanKhalok,

            }
           ,

        };

        public static Branch NorthEasternLine_UbonRatchathani = new Branch
        {
            Name = "North East Line Ubon Ratchathani Branch",
            Description = "North East Line Ubon Ratchathani Branch",
            MainBranch = true,
            Stations = new List<Station>
             {
                ThailandTrainStations.BanPachi,
                ThailandTrainStations.KaengKhoiJuction,
                ThailandTrainStations.ThanonChiraJunction,
                ThailandTrainStations.Surin,
                ThailandTrainStations.Sisaket,
                ThailandTrainStations.UbonRatchathani,
             }
           ,

        };


        public static Branch NorthEasternLineLine_NongKhai = new Branch
        {
            Name = "North East Line Ubon Ratchathani Branch",
            Description = "North East Line Ubon Ratchathani Branch",
            MainBranch = true,
            Stations = new List<Station>
             {
                ThailandTrainStations.BanPachi,
                ThailandTrainStations.KaengKhoiJuction,
                ThailandTrainStations.BuaYaiJunction,
                ThailandTrainStations.KhonKaen,
                ThailandTrainStations.UdonThani,
                ThailandTrainStations.NongKhai,
             }
           ,

        };

        public static Branch NorthEasternLine_BuaYai_ThanonChira = new Branch
        {
            Name = "North East Line Ubon Ratchathani Branch",
            Description = "North East Line Ubon Ratchathani Branch",
            MainBranch = false,
            Stations = new List<Station>
             {
                ThailandTrainStations.BuaYaiJunction,
                ThailandTrainStations.ThanonChiraJunction,
              
             }
   ,

        };



        public static Branch EasternLine_Pattaya = new Branch
        {
            Name = "Eastern Line Pattaya",
            Description = "",
            MainBranch = true,
            Stations = new List<Station>
             {
                ThailandTrainStations.BangkokHuaLamphong,
                ThailandTrainStations.Pattaya,

             }
  ,

        };

        public static Branch EasternLine_Aranyaprathet = new Branch
        {
            Name = "Eastern Line Pattaya",
            Description = "",
            MainBranch = true,
            Stations = new List<Station>
             {
                ThailandTrainStations.BangkokHuaLamphong,
                ThailandTrainStations.Aranyaprathet,

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