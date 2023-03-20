using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public class BorderCrossingService : IBorderCrossingService
    {
        private IUnitOfWork unitOfWork;
        public BorderCrossingService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public ICollection<BorderCrossing> GetBorderCrossingsByOriginCountryID(int CountryID)
        {
            ///Metodo especifico para Repositorio en Countries. No es del repositorio generico.
            var borderCrossings = unitOfWork.BorderCrossingRepository.GetBorderCrossingsByOriginCountryCode(CountryID);

            return borderCrossings.ToList();
        }

        public ICollection<BorderCrossing> GetBorderCrossingsByFinalCountryID(int CountryID)
        {
            ///Metodo especifico para Repositorio en Countries. No es del repositorio generico.
            var borderCrossings = unitOfWork.BorderCrossingRepository.GetBorderCrossingsByFinalCountryCode(CountryID);

            return borderCrossings.ToList();
        }

        public ICollection<BorderCrossing> GetBorderCrossingsByOriginAndFinalCountryCode(int originCountryID, int finalCountryID)
        {
            ///Metodo especifico para Repositorio en Countries. No es del repositorio generico.
            var borderCrossings = unitOfWork.BorderCrossingRepository.GetBorderCrossingsByOriginAndFinalCountryCode(originCountryID, finalCountryID);

            return borderCrossings.ToList();
        }
    }
}
