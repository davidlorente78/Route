using Domain.Repositories;
using Domain.Transport.Aviation;

namespace RouteDataManager.Repositories
{
    public class AirportTypeRepository : GenericRepository<AirportType>, IAirportTypeRepository
    {
        public AirportTypeRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
