using Domain.Repositories;
using Domain.Transport.Aviation;

namespace RouteDataManager.Repositories
{
    public class AirportRepository : GenericRepository<Airport>, IAirportRepository
    {
        public AirportRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
