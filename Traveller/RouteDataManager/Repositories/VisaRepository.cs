using Domain.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class VisaRepository : GenericRepository<Visa>, IVisaRepository
    {
        public VisaRepository(ApplicationContext context) : base(context)
        {
        }

        public int GetMaxStay(int countryId, string nationalityCode)
        {
            var maxDuration = _context.Countries.Where(c => c.Id == countryId)
                .SelectMany(c => c.Visas)
                        .Where(
                            s => s.QualifyNationalities.Select(n => n.Code).Contains(nationalityCode)
                         )
                        .Max(v => v.Duration);

            return (int)maxDuration;

        }
    }
}
