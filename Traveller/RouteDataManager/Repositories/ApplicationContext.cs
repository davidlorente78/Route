using Domain;
using Domain.Ranges;
using Domain.Transport.Aviation;
using Domain.Transport.Railway;
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

        public DbSet<Destination>? Destinations { get; set; }

        public DbSet<BorderCrossing>? BorderCrossings { get; set; }

        public DbSet<DestinationType>? DestinationTypes { get; set; }

        public DbSet<BorderCrossingType>? BorderCrossingTypes { get; set; }

        public DbSet<RailwaySystem>? RailwaySystems { get; set; }

        public DbSet<RailwayLine>? RailwayLines { get; set; }

        public DbSet<RailwayStation>? RailwayStations { get; set; }

        public DbSet<RailwayBranch>? RailwayBranches { get; set; }

        public DbSet<Visa>? Visas { get; set; }

        public DbSet<Airport>? Airports { get; set; }

        public DbSet<AirportType>? AirportTypes { get; set; }

        public DbSet<Airline>? Airlines { get; set; }

        public DbSet<AirlineType>? AirlineTypes { get; set; }

        public DbSet<Nationality>? Nationalities { get; set; }

        public DbSet<RangeChar>? Ranges { get; set; }

        public DbSet<RangeType>? RangeTypes { get; set; }

        public DbSet<Month>? Months { get; set; }

        public DbSet<Traveller.Domain.Route>? Routes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Global turn off delete behaviour on foreign keys
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //Country
            modelBuilder.Entity<Country>()
                .ToTable("Countries")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Country>()
                .HasMany<Destination>(c => c.Destinations)
                .WithOne(d => d.DestinationCountry)
                .HasForeignKey(d => d.DestinationCountryID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Country>()
               .HasMany<BorderCrossing>(c => c.BorderCrossings)
               .WithOne(b => b.BorderCrossingCountry)
               .HasForeignKey(b => b.BorderCrossingCountryID)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Country>()
                .HasMany<Airport>(c => c.Airports)
                .WithOne(a => a.AirportCountry)
                .HasForeignKey(a => a.AirportCountryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Country>()
                 .HasMany<RailwayLine>(c => c.TrainLines)
                 .WithOne(r => r.Country)
                 .HasForeignKey(r => r.CountryID)
                 .OnDelete(DeleteBehavior.Cascade);

            //Destination
            modelBuilder.Entity<Destination>()
                .ToTable("Destinations")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Destination>()
                .HasMany(x => x.Airports)
                .WithMany(x => x.Destinations);

            //BorderCrossings
            modelBuilder.Entity<BorderCrossing>()
               .ToTable("BorderCrossings");

            modelBuilder.Entity<BorderCrossing>()
                .HasOne(b => b.DestinationOrigin)
                .WithMany()
                .HasForeignKey(d => d.DestinationOriginID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BorderCrossing>()
                .HasOne(b => b.DestinationFinal)
                .WithMany()
                .HasForeignKey(d => d.DestinationFinalID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BorderCrossing>()
                .HasMany(b => b.Visas)
                .WithMany(x => x.BorderCrossings)
                .UsingEntity("VisaBorderCrossing");

            modelBuilder.Entity<Airport>()
                .ToTable("Airports")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Airport>()
                .HasMany(x => x.Destinations);

            modelBuilder.Entity<Airport>()
                .HasOne(x => x.AirportCountry);

            modelBuilder.Entity<Airport>()
                .HasOne(x => x.AirportType);

            modelBuilder.Entity<RailwayBranch>().ToTable("Branches");
        }
    }
}
