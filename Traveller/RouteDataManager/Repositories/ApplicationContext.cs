using Microsoft.EntityFrameworkCore;
using Traveller.Domain;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata;
using CURDOperationWithImageUploadCore5_Demo.Models;
using System.Collections;
using Domain.Ranges;
using Domain.Transport.Railway;
using Domain.Transport.Aviation;

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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Countries");

            modelBuilder.Entity<Country>()
                    .HasMany(x => x.Destinations)
                    .WithOne(x => x.DestinationCountry)
                    .HasForeignKey(x => x.DestinationCountryID)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Destination>()
                .ToTable("Destinations")
                .HasKey(x => x.DestinationID);

            modelBuilder.Entity<Destination>()
                   .HasMany(x => x.Airports)
                   .WithMany(x => x.Destinations);

            modelBuilder.Entity<Airport>()
                .ToTable("Airports")
                .HasKey(x => x.AirportID);

            modelBuilder.Entity<Airport>()
                .HasMany(x => x.Destinations);

            modelBuilder.Entity<Airport>()
                  .HasOne(x => x.AirportCountry);

            modelBuilder.Entity<Airport>()
                .HasOne(x => x.AirportType);



            modelBuilder.Entity<RailwayBranch>().ToTable("Branches");

            #region Speakers
            modelBuilder.Entity("CURDOperationWithImageUploadCore5_Demo.Models.Speaker", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Experience")
                    .HasMaxLength(100)
                    .HasColumnType("int");

                b.Property<string>("ProfilePicture")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Qualification")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("SpeakerName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<DateTime>("SpeakingDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("SpeakingTime")
                    .HasColumnType("datetime2");

                b.Property<string>("Venue")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("nvarchar(255)");

                b.HasKey("Id");

                b.ToTable("Speakers");
            });
            #endregion

            // Global turn off delete behaviour on foreign keys
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }


        public DbSet<Destination>? Destinations { get; set; }

        public DbSet<BorderCrossing>? BorderCrossings { get; set; }

        public DbSet<DestinationType>? DestinationTypes { get; set; }

        public DbSet<BorderCrossingType>? BorderCrossingTypes { get; set; }

        public DbSet<RailwaySystem>? RailwaySystems { get; set; }

        public DbSet<RailwayLine>? RailwayLines { get; set; }

        public DbSet<RailwayStation>? RailwayStations { get; set; }

        public DbSet<RailwayBranch>? RailwayBranches { get; set; }

        public DbSet<Visa>? Visas { get; set; }

        public DbSet<Speaker>? Speakers { get; set; }

        public DbSet<Airport>? Airports { get; set; }

        public DbSet<AirportType>? AirportTypes { get; set; }

        public DbSet<Airline>? Airlines { get; set; }

        public DbSet<AirlineType>? AirlineTypes { get; set; }

        public DbSet<Nationality>? Nationalities { get; set; }

        public DbSet<RangeChar>? Ranges { get; set; }

        public DbSet<RangeType>? RangeTypes { get; set; }

        public DbSet<Month>? Months { get; set; }

        public DbSet<Traveller.Domain.Route>? Routes { get; set; }



    }
}
