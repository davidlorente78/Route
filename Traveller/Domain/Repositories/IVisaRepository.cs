using Traveller.Domain;

namespace Domain.Repositories
{
    public interface IVisaRepository : IGenericRepository<Visa>
    {
        public int GetMaxStay(int id, string nationalityCode);
    }
}
