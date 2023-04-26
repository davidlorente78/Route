using Domain.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class DestinationTypeRepository : GenericRepository<DestinationType>, IDestinationTypeRepository
    {
        public DestinationTypeRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
