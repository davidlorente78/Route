using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class DestinationRepository : GenericRepository<Destination>, IDestinationRepository
    {
        public DestinationRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Destination> GetAllIncludingDestinations(int countryId, int destinationTypeId)
        {
            return _context.Destinations
                 .Where(d => d.CountryId == countryId &&
                      d.DestinationTypes.Select(d => d.Id).Contains(destinationTypeId))
                  .Include(d => d.Country)
                  .Include(d => d.DestinationTypes)
                  .OrderBy(d => d.Name).ToList();
        }
    }
}
