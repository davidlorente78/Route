using Domain.Repositories;
using Domain.Transport.Railway;

namespace RouteDataManager.Repositories.Transport.Railway
{
    public class RailwayBranchRepository : GenericRepository<RailwayBranch>, IRailwayBranchRepository
    {
        public RailwayBranchRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
