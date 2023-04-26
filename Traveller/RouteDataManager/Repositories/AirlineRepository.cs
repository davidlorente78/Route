using Domain.Repositories;
using Domain.Transport.Aviation;
using Microsoft.EntityFrameworkCore;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    public class AirlineRepository : GenericRepository<Airline>, IAirlineRepository
    {
        public AirlineRepository(ApplicationContext context) : base(context)
        {
        }     
    }
}
