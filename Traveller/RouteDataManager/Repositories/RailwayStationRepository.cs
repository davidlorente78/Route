using Domain.Repositories;
using Domain.Transport.Railway;

namespace RouteDataManager.Repositories
{
    public class RailwayStationRepository : GenericRepository<RailwayStation>, IRailwayStationRepository
    {
        public RailwayStationRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
