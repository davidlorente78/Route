using Domain.Repositories;
using Domain.Transport.Railway;

namespace RouteDataManager.Repositories
{
    public class RailwayLineRepository : GenericRepository<RailwayLine>, IRailwayLineRepository
    {
        public RailwayLineRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
