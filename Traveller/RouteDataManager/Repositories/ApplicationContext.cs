using Microsoft.EntityFrameworkCore;
using Traveller.Domain;

namespace RouteDataManager.Repositories
{
    /// <summary>
    /// It derives from DBContext class and exposes DbSet properties for the types that you want to be part of the model,
    /// https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/
    /// </summary>
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }


        public DbSet<Country> Countries { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        //    optionsBuilder.UseSqlServer(connectionString);
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Destination>().ToTable("Destination");

            //EF Not Core versions
            //builder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Global turn off delete behaviour on foreign keys
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        //    optionsBuilder.UseSqlServer(connectionString);
        //}


        public DbSet<Destination>? Destinations { get; set; }

        public DbSet<Frontier>? Frontiers { get; set; }

        public DbSet<DestinationType>? DestinationTypes { get; set; }

    }
}
