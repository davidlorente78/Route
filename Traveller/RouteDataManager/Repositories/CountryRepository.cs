using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
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
            ///
            return _context.Countries.Include(c=> c.Destinations).Include(c=> c.Frontiers).OrderBy(c => c.Name).ToList();
        }
    }   
}
