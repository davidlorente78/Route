using Data.EntityTypes;
using System.Reflection;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class NepalDestinations
    {
        public static Destination Kathmandu = new Destination
        {
            CountryId = 7,
            Name = "Kathmandu",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Tourism , DestinationTypes.Airport }
        };

        public static Destination Bharatpur = new Destination
        {
            CountryId = 7,
            Name = "Bharatpur",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Bhadrapur = new Destination
        {
            CountryId = 7,
            Name = "Bhadrapur",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        

        public static Destination Bhairawa = new Destination
        {
            CountryId = 7,
            Name = "Bhairawa",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Janakpur = new Destination
        {
            CountryId = 7,
            Name = "Janakpur",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Nepalgunj = new Destination
        {
            CountryId = 7,
            Name = "Nepalgunj",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Pokhara = new Destination
        {
            CountryId = 7,
            Name = "Pokhara",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination TumlingTar = new Destination
        {
            CountryId = 7,
            Name = "Tumling Tar",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static Destination Biratnagar = new Destination
        {
            CountryId = 7,
            Name = "Biratnagar",
            DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }
        };

        public static List<Destination> GetStaticAll()
        {
            var fields = typeof(NepalDestinations).GetFields(BindingFlags.Static | BindingFlags.Public);

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