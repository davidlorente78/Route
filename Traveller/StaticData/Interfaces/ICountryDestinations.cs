using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace StaticData.Interfaces
{
    public interface ICountryDestinations
    {
        public  List<Destination> GetAll()       

        {
            List<Destination> destinationsFromStatic = GetStaticAll();

            List<Destination> destinationsFromStations = CreateDestinationsFromStations();

            destinationsFromStatic.AddRange(destinationsFromStations);

            return destinationsFromStatic;

        }
        public  List<Destination> GetStaticAll();
        public  List<Destination> CreateDestinationsFromStations();

 
    }
}
