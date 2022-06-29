
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaDestinations
    {
        //Frontiers
        public static Destination Bavet = new Destination { Name = "Bavet", Type = 'F', CountryCode = 'C' };
        public static Destination PrekChak = new Destination { Name = "Prek Chak", Type = 'F', CountryCode = 'C' };
        public static Destination KaanSamnor = new Destination { Name = "Kaan Samnor", Type = 'F', CountryCode = 'C' };


        //Tourist Spots
        public static Destination Angkor = new Destination { Name = "Angkor", Type = 'T', CountryCode = 'C' };
    }
}