using Domain.Repositories;
using Domain.Transport.Aviation;
using Microsoft.EntityFrameworkCore;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class AirportRepository : GenericRepository<Airport>, IAirportRepository
    {
        public AirportRepository(ApplicationContext context) : base(context)
        {
        }     
    }
}
