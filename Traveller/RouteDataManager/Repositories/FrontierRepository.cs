using Domain.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class FrontierRepository : GenericRepository<Frontier>, IFrontierRepository
    {
        public FrontierRepository(ApplicationContext context) : base(context)
        {
        }
    
    }
}
