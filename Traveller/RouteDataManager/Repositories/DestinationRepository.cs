using Domain.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class DestinationRepository : GenericRepository<Destination>, IDestinationRepository
    {
        public DestinationRepository(ApplicationContext context) : base(context)
        {
        }


        //public async Task<IActionResult> Index()
        //{
        //    return _context.Destinations != null ?
        //                View(await _context.Destinations.Include(d => d.Country).ToListAsync()) :
        //                Problem("Entity set 'ApplicationContext.Destination'  is null.");
        //}
        //Include(c=> c.Destinations)
    }
}
