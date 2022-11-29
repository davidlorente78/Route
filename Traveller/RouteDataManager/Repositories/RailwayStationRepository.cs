using Domain.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class RailwayStationRepository : GenericRepository<Domain.Transport.Railway.RailwayStation>, IRailwayStationRepository
    {
        public RailwayStationRepository(ApplicationContext context) : base(context)
        {
        }
    
    }
}
