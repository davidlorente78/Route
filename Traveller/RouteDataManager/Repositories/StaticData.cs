using Traveller.Domain;
using Traveller.StaticData;

namespace RouteDataManager.Repositories
{
    /// <summary>
    /// Comprueba si existe la base de datos:
    ///Si no se encuentra la base de datos,
    ///se crea y se carga con datos de prueba.Carga los datos de prueba en matrices en lugar de colecciones List<T> para optimizar el rendimiento.
    ///Si la base de datos se encuentra, no se realiza ninguna acción.
    /// </summary>
    public class DbInitializer
    {
        public DbInitializer() { }

        public static void Initialize(CountryDbContext context)
        {
            context.Database.EnsureDeleted(); //
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Countries.Any())
            {
                return;   // DB has been seeded
            }


            Country Laos = new Country
            {
                Code = 'L',
                Name = "Laos",
                //Frontiers = LaosFrontiers.Frontiers,
                Destinations = new List<Destination> { LaosDestinations.LPQ, LaosDestinations.VTE, LaosDestinations.Savannakhet },
                //Visas = new List<Visa> { LaosVisas.eLaoVisa, LaosVisas.LaoVisa }
            };


            context.Countries.Add(Laos);
            context.SaveChanges();

        }
    }
}
