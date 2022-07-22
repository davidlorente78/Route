using Microsoft.EntityFrameworkCore;
using Traveller.Domain;
using Domain;

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
            modelBuilder.Entity<Country>().ToTable("Countries");

            //En este caso no es necesario porque ya se encarga EF de formar el plural directamente
            modelBuilder.Entity<Destination>().ToTable("Destinations");

            modelBuilder.Entity<Branch>().ToTable("Branches");


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

        public DbSet<FrontierType>? FrontierTypes { get; set; }

        public DbSet<Line>? Lines { get; set; }

        public DbSet<Station>? Stations { get; set; }

        public DbSet<Branch>? Branches { get; set; }

    }
}
