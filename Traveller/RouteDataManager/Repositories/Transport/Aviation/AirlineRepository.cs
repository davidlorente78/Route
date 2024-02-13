using Domain.Repositories;
using Domain.Transport.Aviation;
using Microsoft.EntityFrameworkCore;
using Traveller.Domain;

namespace RouteDataManager.Repositories.Transport.Aviation
{
    public class AirlineRepository : GenericRepository<Airline>, IAirlineRepository
    {
        public AirlineRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
