using Data.EntityTypes;
using System.Reflection;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class PhilippinesDestinations
    {
        public static Destination Coron = new Destination
        {
            Name = "Coron (Palawan)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination ElNido = new Destination
        {
            Name = "El Nido (Palawan)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination Siquijor = new Destination
        {
            Name = "Siquijor (Negros Oriental)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination ApoIsland = new Destination
        {
            Name = "Apo Island (Negros Oriental)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination Manila = new Destination
        {
            Name = "Manila (Luzon)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination Zambales = new Destination
        {
            Name = "Zambales San Narciso (Luzon)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination Dumaguete = new Destination
        {
            Name = "Dumaguete (Negros Oriental)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination ApoReef = new Destination
        {
            Name = "Apo Reef San Jose (Mindoro Occidental)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination PuertoGalera = new Destination
        {
            Name = "Puerto Galera Sabang (Mindoro Occidental)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };

        public static Destination Tablas = new Destination
        {
            Name = "Tablas Binucot (Romblon)",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism }
        };
           

        public static List<Destination> GetStaticAll()
        {
            var fields = typeof(PhilippinesDestinations).GetFields(BindingFlags.Static | BindingFlags.Public);

            var destinations = new List<Destination>();

            foreach (var field in fields)
            {
                if (field.FieldType == typeof(Destination))
                {
                    destinations.Add((Destination)field.GetValue(null));
                }
            }

            return destinations;
        }

    }
}
