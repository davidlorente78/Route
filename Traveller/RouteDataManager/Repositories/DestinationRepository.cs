using Domain.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class DestinationRepository : GenericRepository<Destination>, IDestinationRepository
    {
        public DestinationRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Destination> GetAllDestinationsOrderByName()
        {
            var destinationsList = new List<Destination>();

            destinationsList = _context.Destinations.OrderBy(c => c.Name).ToList();

            return destinationsList;
        }       
    }
}
