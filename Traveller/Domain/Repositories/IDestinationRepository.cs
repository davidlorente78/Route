using Traveller.Domain;

namespace Domain.Repositories
{    
    public interface IDestinationRepository : IGenericRepository <Destination>
    {
        IEnumerable<Destination> GetAllIncludingDestinations(int countryId, int destinationTypeId);
    }
}
