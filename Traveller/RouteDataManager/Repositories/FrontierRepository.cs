using Domain.Repositories;
using Traveller.Domain;
using Microsoft.EntityFrameworkCore;
namespace RouteDataManager.Repositories
{
    public class FrontierRepository : GenericRepository<Frontier>, IFrontierRepository
    {
        public FrontierRepository(ApplicationContext context) : base(context)
        {

        }

        public IEnumerable<Frontier> GetFrontiersByOriginCountryCode(int OriginCountryID) {

            ///
            return _context.Frontiers.Where(f=>f.Origin.CountryID== OriginCountryID).Include(f => f.Final).Include(f => f.Origin).OrderBy(c => c.Name).ToList();
        }

        public IEnumerable<Frontier> GetFrontiersByFinalCountryCode(int FinalCountryID)
        {

            ///
            return _context.Frontiers.Where(f => f.Final.CountryID == FinalCountryID).Include(f => f.Final).Include(f => f.Origin).OrderBy(c => c.Name).ToList();
        }

        public IEnumerable<Frontier> GetFrontiersByOriginAndFinalCountryCode(int OriginCountryID, int FinalCountryID)
        {
                        ///
            return _context.Frontiers.Where(f => f.Final.CountryID == FinalCountryID && f.Origin.CountryID == OriginCountryID).Include(f => f.Final).Include(f => f.Origin).OrderBy(c => c.Name).ToList();
        }
    }
}
