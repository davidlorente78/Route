using Microsoft.EntityFrameworkCore;
using Traveller.Domain;

namespace Data
{
    /// <summary>
    /// It derives from DBContext class and exposes DbSet properties for the types that you want to be part of the model,
    /// </summary>
    public class CountryDbContext : DbContext
    {
        /// </summary>       
        public DbSet<Country>? Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
