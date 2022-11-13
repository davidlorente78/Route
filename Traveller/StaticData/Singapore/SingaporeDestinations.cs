using Data.EntityTypes;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class SingaporeDestinations
    {

        public static Destination Singapore = new Destination { Name = "Singapore", DestinationTypes = new List<DestinationType> { DestinationTypes.Airport }, Description = "Singapore" };

        /// <summary>
        /// https://www.mochiadictos.com/cruzar-la-frontera-singapur-malasia-por-tierra/
        /// </summary>
        public static Destination WoodlandsCheckpoint = new Destination { Name = "Woodlands Checkpoint", DestinationTypes = new List<DestinationType> { DestinationTypes.Frontier }, Description= "The Woodlands Checkpoint is one of Singapore's two land border checkpoints, connecting ground traffic with Malaysia. It services the vehicular traffic (cars, buses, lorries, motorcycles) along with pedestrians that goes through the Johor–Singapore Causeway." };

    }
}
