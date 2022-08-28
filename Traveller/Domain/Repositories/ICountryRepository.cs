using Traveller.Domain;

namespace Domain.Repositories
{
    /// <summary>
    /// Now what happens if we need the records of Most Popular Developers from our Database? We do not have a function for it in our Generic Class, do we ? This is where we can see the advantage of building a Generic Repository.
    /// Here we are inheriting all the Functions of the Generic Repository, as well as adding a new Funciton ‘GetPopularDevelopers’. Get it?
    /// </summary>
    public interface ICountryRepository: IGenericRepository<Country>
    {
        IEnumerable<Country> GetCountriesOrderedByName();

        //TODO Este es Country sin ENUMERABLE
        IEnumerable<Country> GetCountryByID(int id);

        public Country GetCountryByCode(char ch);

        public Country GetCountryRangesByCode(char ch);
    }
}
