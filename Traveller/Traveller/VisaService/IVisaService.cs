using RouteDataManager.Repositories;
using System.Linq;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface IVisaService
    {
        public int GetMaxStay(char countryCode, string nationalityCode);   

    }
}
