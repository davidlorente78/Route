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
            ///TODO Include Frontiers
            return _context.Countries.Include(c=> c.Destinations).OrderBy(c => c.Name).ToList();
        }

        public IEnumerable<Country> GetCountryByID(int id)
        {
            ///
            return _context.Countries.Where(c=> c.CountryID == id).Include(c => c.Destinations).OrderBy(c => c.Name).ToList();
        }
        
    }   
}
