using Domain.Interfaces;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(ApplicationContext context) : base(context)
        {
        }
        public IEnumerable<Country> GetCountriesOrderedByName()
        {
            return _context.Countries.OrderBy(c => c.Name).ToList();
        }
    }
}
