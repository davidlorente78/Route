using Domain.Repositories;
using Domain.Transport.Railway;

namespace RouteDataManager.Repositories.Transport.Railway
{
    public class RailwayStationRepository : GenericRepository<RailwayStation>, IRailwayStationRepository
    {
        public RailwayStationRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
