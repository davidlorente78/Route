using Traveller.Application.Dto;
using Traveller.Domain;

namespace RouteDataManager.ViewModels.Country
{
    public class CountryIndexViewModel
    {
        /// <summary>
        /// En la página Country Index se muestran tres tablas diferentes. Por tanto, creará un modelo de vista que incluye tres propiedades, cada una con los datos de una de las tablas.
        /// </summary>
        public IEnumerable<CountryDto> Countries { get; set; }
        public IEnumerable<Traveller.Domain.Destination> Destinations { get; set; }
        public IEnumerable<BorderCrossing> BorderCrossings { get; set; }

        public IEnumerable<Visa> Visas { get; set; }
    }
}
