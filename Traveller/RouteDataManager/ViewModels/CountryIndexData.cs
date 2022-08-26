using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class CountryIndexData
    {
        /// <summary>
        /// En la En la página Country Index se muestran tres tablas diferentes. Por tanto, creará un modelo de vista que incluye tres propiedades, cada una con los datos de una de las tablas.
        /// </summary>
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Traveller.Domain.Destination> Destinations { get; set; }
        public IEnumerable<Frontier> Frontiers { get; set; }

        public IEnumerable<Visa> Visas { get; set; }
    }
}
