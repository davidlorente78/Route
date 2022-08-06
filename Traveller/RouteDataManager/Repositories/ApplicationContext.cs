using Microsoft.EntityFrameworkCore;
using Traveller.Domain;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata;
using CURDOperationWithImageUploadCore5_Demo.Models;
using System.Collections;

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

        public DbSet<Visa>? Visa { get; set; }

        public DbSet<Speaker>? Speakers { get; set; }

        public DbSet<RailwaySystem>? RailwaySystems { get; set; }

        public DbSet<Airport>? Airports { get; set; }

        public DbSet<AirportType>? AirportTypes { get; set; }
    }
}
