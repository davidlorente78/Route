using Data.EntityTypes;
using Data.Malaysia;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class MalaysiaDestinations
    {
        public static Destination PadangPesar = new Destination { Name = "Padang Pesar", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination RantanPanjang = new Destination { Name = "Rantan Panjang", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination KotaBahru = new Destination { Name = "Kota Bahru", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing } };
        public static Destination Penang = new Destination {  DestinationCountryID=4, Name = "Penang", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing, DestinationTypes.Airport } };
        public static Destination KUL = new Destination { Name = "Kuala Lumpur Airport", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport } };
        public static Destination JohorBahru = new Destination { DestinationCountryID = 4, Name = "Johor Bahru", DestinationTypes = new List<DestinationType> { DestinationTypes.BorderCrossing , DestinationTypes.Airport } };
        public static Destination Butterworth = new Destination { Name = "Butterworth", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
        public static Destination KualaLumpur = new Destination { DestinationCountryID = 4, Picture = "/KualaLumpur.jpg", Name = "Kuala Lumpur", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };
        public static Destination KualaKangsar = new Destination { Name = "Kuala Kangsar", Picture = "/KualaKangsar.jpg", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism } };
        public static Destination Ipoh = new Destination { Name = "Ipoh",  Picture = "/Ipoh.jpg", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism , DestinationTypes.Airport} };
        public static Destination KotaKinabalu = new Destination { Name = "Kota Kinabalu", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };
        public static Destination Langkawi = new Destination { Name = "Langkawi", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };
        public static Destination Kuching = new Destination { Name = "Kuching", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };
        public static Destination AlorSatar = new Destination { Name = "Alor Satar", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };
        public static Destination KotaBaharu = new Destination { Name = "Kota Baharu", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };
        public static Destination KualaTerengganu = new Destination { Name = "Kuala Terengganu", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };
        public static Destination Subang = new Destination { Name = "Subang", DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism, DestinationTypes.Airport } };

        public static List<Destination> GetStaticAll()
        {
            return new List<Destination> {
                KualaLumpur,
                RantanPanjang,
                PadangPesar,
                KualaLumpur,
                Penang,
                Butterworth,
                KotaBahru,
                KUL,
                JohorBahru,
                KotaKinabalu,
                Langkawi,
                Kuching,
                AlorSatar,
                KotaBaharu,
                KualaTerengganu,
                Subang,                     
                KualaKangsar,
                Ipoh
            };
        }

        public static List<Destination> CreateDestinationsFromStations()
        {
            List<Destination> destinations = new List<Destination>();

            List<Destination> staticdestinations = GetStaticAll();

            var trainLines = MalaysiaTrainLines.GetAll();

            foreach (var trainLine in trainLines)
            {
                foreach (var branch in trainLine.Branches)
                {
                    foreach (var station in branch.Stations)
                    {
                        if (!staticdestinations.Where(x => x.Name == station.Name).Any())
                        {
                            Destination destination = new Destination
                            {
                                Name = station.Name,
                                DestinationTypes = new List<DestinationType> { DestinationTypes.Train }
                            };

                            destinations.Add(destination);
                        }
                        else
                        {
                            var exist = staticdestinations.Where(x => x.Name == station.Name).FirstOrDefault();
                            exist.DestinationTypes.Add(DestinationTypes.Train);
                        }
                    }
                }
            }

            return destinations;
        }

        public static List<Destination> GetAll()
        {
            List<Destination> destinationsFromStatic = GetStaticAll();

            List<Destination> destinationsFromStations = CreateDestinationsFromStations();

            destinationsFromStatic.AddRange(destinationsFromStations);

            return destinationsFromStatic;
        }
    }
}
