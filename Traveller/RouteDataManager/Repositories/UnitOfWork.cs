using Domain.Interfaces;

namespace RouteDataManager.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Countries = new CountryRepository(_context);
            Destinations = new DestinationRepository(_context);
            Frontiers = new FrontierRepository(_context);
        }
        public ICountryRepository Countries { get; private set; }

        public IDestinationRepository Destinations { get; private set; }
        public IFrontierRepository Frontiers { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
