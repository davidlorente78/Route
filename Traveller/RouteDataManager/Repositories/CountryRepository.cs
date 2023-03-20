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
            var countryList = new List<Country>();

            countryList = _context
                .Countries
                    .Include(c => c.Destinations)
                        .ThenInclude(d => d.DestinationTypes)                
                    .Include(c => c.BorderCrossings)
                        .ThenInclude(f => f.BorderCrossingType)
                    .Include(c => c.BorderCrossings)
                        .ThenInclude(b => b.Visas)
                    .OrderBy(c => c.Name).ToList();

            return countryList;
        }

        public IEnumerable<Country> GetCountryByID(int id)
        {
            return _context.Countries.Where(c => c.Id == id)
                .Include(c => c.Destinations)
                .Include(c => c.BorderCrossings)
                    .ThenInclude(b=>b.DestinationOrigin)
                .Include(c => c.BorderCrossings)
                    .ThenInclude(c => c.Visas)
                .OrderBy(c => c.Name).ToList();
        }

        public Country GetCountryByCode(char ch)
        {
            return _context.Countries.Where(c => c.Code == ch)
                .Include(c => c.Destinations)
                .Include(c => c.BorderCrossings)
                    .ThenInclude(c => c.Visas).ThenInclude(v => v.QualifyNationalities)
                 .OrderBy(c => c.Name).FirstOrDefault();
        }

        public Country? GetCountryIncludingRangesByCode(char ch)
        {
            return _context.Countries?
                .Where(c => c.Code == ch)
                .Include(c => c.Ranges)
                .ThenInclude(r => r.RangeType)
                .FirstOrDefault();
        }

    }
}
