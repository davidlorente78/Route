using Domain.Repositories;
using Domain.Transport.Railway;

namespace RouteDataManager.Repositories.Transport.Railway
{
    public class RailwayLineRepository : GenericRepository<RailwayLine>, IRailwayLineRepository
    {
        public RailwayLineRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
