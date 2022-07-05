using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class MalasiaVisas
    {
        public static Visa freeVisa = new Visa
        {
            CountryCode = 'M',
            Currency = '$',
            Fee = 0,
            Entries = 'S',
            Name = "Visado gratuito para estancias inferiores a 90 dias",
            Validity = 0,
            OnLine = false,
            Duration = 90,
            Category = "Visado gratuito para estancias inferiores a 90 dias.",
            Extensible = true,

            //ValidEntryPoints = new List<Destination> { MalasiaDestinations.PadangPesar, MalasiaDestinations.RantanPanjang }
        };



    }
}
