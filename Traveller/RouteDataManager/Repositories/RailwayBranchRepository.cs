using Domain.Repositories;
using Domain.Transport.Railway;

namespace RouteDataManager.Repositories
{
    public class RailwayBranchRepository : GenericRepository<RailwayBranch>, IRailwayBranchRepository
    {
        public RailwayBranchRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
