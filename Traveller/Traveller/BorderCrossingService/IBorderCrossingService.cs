using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface IBorderCrossingService
    {
        ICollection<BorderCrossing> GetBorderCrossingsByOriginCountryID(int originCountryID);
        ICollection<BorderCrossing> GetBorderCrossingsByFinalCountryID(int finalCountryID);
        ICollection<BorderCrossing> GetBorderCrossingsByOriginAndFinalCountryCode(int originCountryID, int finalCountryID);
    }
}