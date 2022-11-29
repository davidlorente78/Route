using Domain.Repositories;

namespace RouteDataManager.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public ICountryRepository ICountryRepository { get; private set; }
        public IDestinationRepository IDestinationRepository { get; private set; }
        public IBorderCrossingRepository IBorderCrossingRepository { get; private set; }
        public IRailwayStationRepository IRailwayStationRepository { get; private set; }


        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            ICountryRepository = new CountryRepository(_context);
            IDestinationRepository = new DestinationRepository(_context);
            IBorderCrossingRepository = new BorderCrossingRepository(_context);
            IRailwayStationRepository = new RailwayStationRepository(_context);
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
