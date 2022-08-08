using StaticData;
using StaticData.Cambodia;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaFrontiers
    {


        public static List<Frontier> GetAll()

        {
            List<Frontier> terrestrial = GetAllTerrestrialFrontiers();

            List<Frontier> frontiersFromAirports = CreateFrontiersFromInternationalAirports();

            terrestrial.AddRange(frontiersFromAirports);

            return terrestrial;

        }

        public static List<Frontier> CreateFrontiersFromInternationalAirports()
        {
            List<Frontier> frontiers = new List<Frontier>();


            var airports = CambodiaAirports.GetAll();

            foreach (var airport in airports.Where(a => a.AirportType == AirportTypes.International))
            {

                Frontier frontierFromAirport = new Frontier()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    Origin = airport.ServingDestinations.FirstOrDefault(),
                    Final = airport.ServingDestinations.FirstOrDefault(),
                    FrontierType = FrontierTypes.Airport,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption },
                };

                frontiers.Add(frontierFromAirport);


            }

            return frontiers;

        }
        public static List<Frontier> GetAllTerrestrialFrontiers()
        {
            return new List<Frontier> {

                new Frontier {
                        Name = "Poipet",
                        Origin = ThailandDestinations.Aranyaprathet,
                        Final = CambodiaDestinations.Poipet,
                        FrontierType = FrontierTypes.Terrestrial,

                        }
                 };


        }


    }
}
