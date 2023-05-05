using Domain;
using Domain.Repositories;

namespace RouteDataManager.Repositories
{
    public class NationalityRepository : GenericRepository<Nationality>, INationalityRepository
    {
        public NationalityRepository(ApplicationContext context) : base(context)
        {
        }

        public Nationality? GetByCode(string code)
        {

            return _context.Nationalities
                     .Where(n => n.Code == code).FirstOrDefault();

        }
    }
}
