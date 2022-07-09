using StaticData;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class SingaporeDestinations
    {

        public static Destination SIN = new Destination { Name = "Singapore Changi Airport", DestinationType = DestinationTypes.Airport, CountryCode = 'S', Description = "Singapore International Airport" };

        /// <summary>
        /// https://www.mochiadictos.com/cruzar-la-frontera-singapur-malasia-por-tierra/
        /// </summary>
        public static Destination WoodlandsCheckpoint = new Destination { Name = "Woodlands Checkpoint", DestinationType = DestinationTypes.Frontier, CountryCode = 'S' , Description= "The Woodlands Checkpoint is one of Singapore's two land border checkpoints, connecting ground traffic with Malaysia. It services the vehicular traffic (cars, buses, lorries, motorcycles) along with pedestrians that goes through the Johor–Singapore Causeway." };

    }
}
