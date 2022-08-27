using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Thailand
{   //https://www.thaiembassy.com/thailand/thailands-land-borders
    public class ThailandFrontiers

    //Also, you should be aware that there is a rule that you can only obtain two visa-exempt entries at land borders per calendar year, but there is no such restriction by air.
    {
        public static List<Frontier> GetAllTerrestrialFrontiers()
        {
            return new List<Frontier>
            {
                new Frontier
                {
                    Name = "Thailand Laos Frienship Bridge I ",
                    Origin = LaosDestinations.Vientiane,
                    Final = ThailandDestinations.NongKhai,
                    Description = "With a “Friendship Bridge” separating the two countries, this border can be crossed easily using international buses, private taxis, or a tuk-tuk. You should be wary of any taxi or tuk-tuk drivers trying to take you anywhere other than the crossing itself as they are likely trying to get you to use and pay for the service of a travel agent who won’t do much more than fill out the forms for you.",
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa>
                    { ThailandVisas.VisaExemption_Thailand
                    },

                }

                         ,

                new Frontier
                {
                    Name = "Thailand Laos Frienship Bridge II ",
                    Origin = LaosDestinations.Savannakhet,
                    Final = ThailandDestinations.Mukdahan,
                    Description = "Located in the northeastern region known as Isaan, Mukdahan and Savannakhet are separated by a bridge spanning the mighty Mekong River (the second “Friendship Bridge”). This crossing is very popular with ex-pats and tourists due to the Thai embassy in Savannakhet, which has long been known as one of the friendlier embassies where you can obtain a new visa and then re-enter Thailand. Savannakhet, although a fairly small, dusty provincial Laos town, does have a few markets, bars, and various restaurants, as well as a casino and, will keep you busy for a day or two whilst you wait for your visa to be processed (which is an overnight process). It is about two hours from Nakhon Phanom and there are two buses an hour from Mukdahan. There is no train line to Mukdahan",
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },

                }

                         ,

                new Frontier
                {
                    Name = "Chiang Khong - Huay Xai",
                    Origin = LaosDestinations.HuayXai,
                    Final = ThailandDestinations.ChiangKhong,
                    Description = "",
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },

                }

                         ,

                new Frontier
                {
                    Name = "Padang Pesar - Padang Pesar (Pekan Siam)",
                    Origin = MalaysiaDestinations.PadangPesar,
                    Final = ThailandDestinations.PadangPesar,
                   FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                    Description ="This crossing can be reached easily on both sides by public transport, including train (in which case you’ll need to alight from the train to clear immigration before getting back on). Known as a fairly friendly crossing, however, if you’re trying to enter Thailand here on a visa-exempt entry, they have been known to ask for a hotel booking and flight out of Thailand (as well as a sufficient amount of cash) before stamping you in, although these requests seem to be applied inconsistently. This can cause a bit of a headache if you haven’t made any plans yet, but you can make a booking with your smartphone and show it to them if you need to, so ensure you have some credit on your phone as you won’t be allowed to use their Wi-Fi."

                }

                         ,

                new Frontier
                {
                    Name = "Sungai Kolok - Rantan Panjang",
                    Origin = MalaysiaDestinations.RantanPanjang,
                    Final = ThailandDestinations.SungaiKolok,
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                    Description ="A popular crossing, there is plenty of public transportation available on both sides. Once stamped out, you’ll have a short walk across a bridge before being stamped into your next country. There are plenty of taxi drivers lurking on both sides of the border happy to give you a ride. Sungai Kolok is a small town, but it has a lot of very good value guesthouses and restaurants and would be a good place to spend the night if you’ve been traveling all day, then can cross the border first thing in the morning."
                }

                         ,

//                MalasiaFrontiers
//                Wang Prajan
//A small, quiet, and not as well-known crossing, there’s not much to see or do on either side but it is scenic, as on the Thai side is the Thale Ban national park.Songtaews run-up to the border from Satun on the Thai side and taxis are available on the Malaysian side but you may need to ask someone at immigration to call one for you.There is a big weekend market and the ASEAN grand bazaar on the Thai side, alongside a few restaurants serving southern - style Thai food.


//                Sadao / Chanlung
//Open 24 hours a day, this is a popular crossing but be warned, there’s not much on the Malaysian side and therefore can be a bit awkward finding public transport.There are plenty of places to eat and drink on both sides, with some bars and supermarkets on the Thai side and some very nice Nasi Kandar(Indian-style curry and rice) restaurants on the Malaysian side.Frequently used by western travelers.
            
                
                
//                Langkawi/Satun
//The ferry from either Koh Lipe or Satun (on the mainland) in Thailand to Langkawi runs several times per day, weather permitting, and is another popular crossing into Malaysia. A convenient and easy way to cross, however, if you’re entering Thailand from Langkawi and have a history of many visits to Thailand recently, expect to at least be questioned about what you’re doing in Thailand, if they’re not satisfied with your responses then you could well be denied entry.
                
                
                new Frontier
                {
                    Name = "Chong Mek - Vang Tao",
                    Origin = LaosDestinations.ChongMek,
                    Final = ThailandDestinations.VangTao,
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                    Description = "The towns on both sides of this border are small and don’t have much to see or do other than shop at some fairly basic markets or grab a bite to eat. Once through to the crossing itself, there is a walk of a few hundred meters to enter the other immigration checkpoint. Chong Mek is around 100km east of Ubon Ratchathani, takes around an hour and a half in a taxi, and costs around 1000 baht ($33). On the Laos side, Pakse is the first point of interest and is about 40km or so east of the crossing, and takes under an hour to reach."
                }

                ,


                new Frontier
                {
                    Name = "Aranyaprathet",
                    Origin = CambodiaDestinations.Poipet,
                    Final = ThailandDestinations.Aranyaprathet,
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                    Description ="By far the most popular crossing into Cambodia, this crossing can be reached by bus from Bangkok in around four hours. Hot and dusty, the plot of land between the two immigration offices is packed with casinos, which in general should be avoided. The immigration officials at this crossing are known for being overly militant when checking your details and may even deny entry back into Thailand if they think you’ve stayed “too long”. Also, this checkpoint is known for being rife with touts and scammers, don’t even think about changing your money here unless you want to lose a third of it immediately. In reality, if you have been in and out of Thailand several times already, you should avoid this crossing entirely and either use a different crossing or even fly into Thailand."
                },

                 new Frontier {
                        Name = "Ban Hat Lek Border Check Point",
                        Origin = CambodiaDestinations.ChamYeam,
                        Final = ThailandDestinations.BanHatLek, //Trat Province
                        FrontierType = FrontierTypes.Terrestrial,

                        },

                  new Frontier {
                        Name = "Ban Pakkad Border Checkpoint (Thailand)",
                        Origin = CambodiaDestinations.Prom,
                        Final = ThailandDestinations.KhlongYai, //Ban Pakkad Border Checkpoint  WFGV+H9P, Khlong Yai, Pong Nam Ron District, Chanthaburi 22140, Tailandia
                        FrontierType = FrontierTypes.Terrestrial,
                         Description = "This smaller, quieter crossing is not frequently used by tourists but you may find it handy if you find yourself in the area. On the Thai side, it is close to Chanthaburi, about an hour’s drive away, and Koh Chang, which is about two hours away. The unremarkable town of Pailin is about half an hour’s drive away on the Cambodian side. Realistically, it’s likely that other border crossings will be more convenient, however here they do issue visas on arrival."
                       
                        },


                  //CambodiaFrontiers
                  //Had Lek/Koh Kong
                  //This crossing allows you to travel from the island of Koh Chang in the east of Thailand to the beach town of Sihanoukville in Cambodia. It is quite convenient, however, to make your crossing into Cambodia smoother, it’s advisable to have your Cambodian visa sorted out before arriving at the crossing, as the officials there can make it a slow and tedious process, and there are reports of many people being charged too much when trying to obtain their visa at the crossing itself. You can obtain your Cambodian visa in Bangkok

                  //Chong Jom/O Smach
                //If you find yourself in Isaan, this border crossing is very convenient if you want to travel to Siem Reap and visit the temples at Angor Wat.Close to Surin on the Thai side, it’s fairly easy to find a taxi or minibus on the Cambodian side which will take you on to Siem reap.Not usually very busy, but you may see a few westerners traveling with their Thai wives.Expect to pay around 350 baht(around $11.50) for public transport to Siem Reap, the buses tend to depart from opposite the O Smach Casino Resort.
           
                //Chong Sa Ngam/Anlong Veng
                //A quieter crossing only really worthwhile if you insist on traveling to the small town of Anlong Veng, although it does now have a casino. There is little to no public transportation available on either side of the border here, so not generally recommended.

//                  Ban Laem/Daun Lem
//Another small and quiet border crossing not far from the Ban Pakard crossing, which for most travelers will be a better option as they can issue Cambodian visas.In Ban Laem on the Thai side, you will find a very busy and hectic market selling all kinds of goods at rock - bottom prices, it’s a great place to pick up some cheap clothes, souvenirs, and perfume.
            };
        }

        public static List<Frontier> CreateFrontiersFromInternationalAirports()
        {
            List<Frontier> frontiers = new List<Frontier>();


            var airports = ThailandAirports.GetAll();

            foreach (var airport in airports.Where(a=> a.AirportType == AirportTypes.International)) {

                Frontier frontierFromAirport = new Frontier()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    Origin = airport.Destinations.FirstOrDefault(),
                    Final = airport.Destinations.FirstOrDefault(),
                    FrontierType = FrontierTypes.Airport,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                };

                frontiers.Add(frontierFromAirport);


            }

            return frontiers;

        }

        public static List<Frontier> GetAll()

        {
            List<Frontier> terrestrial = GetAllTerrestrialFrontiers();

            List<Frontier> frontiersFromAirports = CreateFrontiersFromInternationalAirports();

            terrestrial.AddRange(frontiersFromAirports);

            return terrestrial;

        }
    }
}
    


//Myanmar Borders

//Mae Sai/Tachilek
//A very busy and bustling border crossing with plenty to see and do on both sides, popular not only with visa-runners but also with locals crossing for work or to visit the casinos and nightlife venues on the Myanmar side. The crossing is about 65km north of Chiang Rai, with its famous white temple, and is convenient for visa runners. Trying to exit Thailand and re-enter quickly will not be successful at this crossing, they have completely banned the practice.

//Mae Sot/Myawaddy
//Located in Tak province, the charming town of Mae Sot might be a convenient place to exit the country if your visa has nearly expired. With a short walk across a bridge, there is plenty of public transport available on both sides, however, it is advisable to have your Burmese visa ready before heading here to avoid any hassle.

//Phu Nam Ron/Htee Khee
//About 70km west of Kanchanaburi, this quiet crossing does not issue visas on-site therefore you’ll need to have got your visa beforehand in Bangkok. There’s not much public transportation available on either side, particularly if you arrive late in the day you will probably struggle to find a taxi. The crossing is open from 6 am to 6 pm Thai time, and 5:30 am to 5:30 pm on the Myanmar side. It can get quite busy at the weekend with Thais and Burmese making the crossing, which will increase the processing time. Expect to pay around 950 baht ($30) for your Burmese visa on arrival, and 100 baht($3.30) for the bus which takes you across the border.

//Ranong / Kawthaung
//Located right at the narrowest part of the Isthmus of Thailand, this border crossing is very handy if you want to visit Myanmar’s beautiful Andaman islands. You can also visit the Burmese region of Kauthaung without a visa for up to two weeks. The crossing involves a 30-minute ride in a longtail boat, and then you’ll have to pay $10 for the stamp but be warned they will only accept a pristine $10 note, if you don’t have one then you’ll be charged 500 baht.
