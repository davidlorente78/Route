using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface IBorderCrossingService
    {
        ICollection<BorderCrossing> GetFrontiersByOriginCountryID(int originCountryID);
        ICollection<BorderCrossing> GetFrontiersByFinalCountryID(int finalCountryID);
        ICollection<BorderCrossing> GetFrontiersByOriginAndFinalCountryCode(int originCountryID, int finalCountryID);
    }
}