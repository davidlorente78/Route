using Domain.Repositories;

namespace RouteDataManager.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public ICountryRepository CountryRepository { get; private set; }
        public IDestinationRepository DestinationRepository { get; private set; }
        public IBorderCrossingRepository BorderCrossingRepository { get; private set; }
        public IRailwayStationRepository RailwayStationRepository { get; private set; }

        public IRailwayLineRepository RailwayLineRepository { get; private set; }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            CountryRepository = new CountryRepository(_context);
            DestinationRepository = new DestinationRepository(_context);
            BorderCrossingRepository = new BorderCrossingRepository(_context);
            RailwayStationRepository = new RailwayStationRepository(_context);
            RailwayLineRepository = new RailwayLineRepository(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
