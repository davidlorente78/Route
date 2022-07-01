using Domain.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class DestinationRepository : GenericRepository<Destination>, IDestinationRepository
    {
        public DestinationRepository(ApplicationContext context) : base(context)
        {
        }

    }
}
