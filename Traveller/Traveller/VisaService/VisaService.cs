using RouteDataManager.Repositories;
using System.Linq;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public class VisaService : IVisaService
    {

        private IUnitOfWork unitOfWork;
        public VisaService(IUnitOfWork unitOfWork)
        {

            this.unitOfWork = unitOfWork;

        }
        public int GetMaxStay(char countryCode, string nationalityCode)
        {
            var country = unitOfWork.ICountryRepository.GetCountryByCode(countryCode);

            if (country.Visas.Count != 0)
            {
                var maxDuration = country.Visas
                        .Where(
                            s => s.QualifyNationalities.Select(n => n.Code).Contains(nationalityCode)
                         )
                        .Max(v => v.Duration);

                return (int)maxDuration;
            }

            return 0;
        }




    }
}
