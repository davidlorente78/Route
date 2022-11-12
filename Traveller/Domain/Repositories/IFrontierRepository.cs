﻿using Traveller.Domain;

namespace Domain.Repositories
{
    /// <summary>
    /// You can see that the interface and implementations are quite blank. So why create new class and interface for Project? This can also attribute to a good practice while developing applications. We also anticipate that in future, there can be functions that are spcific to the Project Entity. To support them later on, we provide with interfaces and classes. 
    /// </summary>
    public interface IBorderCrossingRepository : IGenericRepository<BorderCrossing>
    {
        IEnumerable<BorderCrossing> GetBorderCrossingsByOriginCountryCode(int CountryID);

        IEnumerable<BorderCrossing> GetBorderCrossingsByFinalCountryCode(int CountryID);

        IEnumerable<BorderCrossing> GetBorderCrossingsByOriginAndFinalCountryCode(int originCountryID, int finalCountryID);

    }
}
