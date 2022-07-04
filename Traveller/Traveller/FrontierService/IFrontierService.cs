using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public interface IFrontierService
    {
        ICollection<Frontier> GetFrontiersByOriginCountryID(int originCountryID);
        ICollection<Frontier> GetFrontiersByFinalCountryID(int finalCountryID);
        ICollection<Frontier> GetFrontiersByOriginAndFinalCountryCode(int originCountryID, int finalCountryID);
    }
}