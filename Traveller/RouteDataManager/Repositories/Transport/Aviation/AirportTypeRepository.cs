using Domain.Repositories;
using Domain.Transport.Aviation;

namespace RouteDataManager.Repositories.Transport.Aviation
{
    public class AirportTypeRepository : GenericRepository<AirportType>, IAirportTypeRepository
    {
        public AirportTypeRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
