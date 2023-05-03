namespace Test
{
    using Application.Mapper;
    using Application.Mapper.Generic;
    using Application.Profiles;
    using Domain.Repositories;
    using DomainServices.AirlineService;
    using DomainServices.CountryService;
    using DomainServices.DestinationService;
    using DomainServices.Generic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using RouteDataManager.Repositories;
    using Traveller.DomainServices;
    using Traveller.RouteService;
    using Traveller.RuleService;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(
                options =>
                options
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RouteDataManager;Trusted_Connection=True;MultipleActiveResultSets=true")
                );

            services.AddTransient<IBorderCrossingService, BorderCrossingService>();
            services.AddScoped(typeof(IGenericMapper<,>), typeof(GenericMapper<,>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));

            services.AddScoped(typeof(ICountryMapper), typeof(CountryMapper));
            services.AddScoped(typeof(IDestinationMapper), typeof(DestinationMapper));
            services.AddScoped(typeof(IDestinationTypeMapper), typeof(DestinationTypeMapper));
            services.AddScoped(typeof(IAirportMapper), typeof(AirportMapper));
            services.AddScoped(typeof(IAirportTypeMapper), typeof(AirportTypeMapper));
            services.AddScoped(typeof(IAirlineMapper), typeof(AirlineMapper));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IBorderCrossingRepository, BorderCrossingRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            services.AddScoped<IDestinationTypeRepository, DestinationTypeRepository>();
            services.AddScoped<IRailwayStationRepository, RailwayStationRepository>();
            services.AddScoped<IAirportRepository, AirportRepository>();
            services.AddScoped<IAirportTypeRepository, AirportTypeRepository>();
            services.AddScoped<IAirlineRepository, AirlineRepository>();

            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IDestinationTypeService, DestinationTypeService>();
            services.AddScoped<IAirportService, AirportService>();
            services.AddScoped<IAirportTypeService, AirportTypeService>();
            services.AddScoped<IAirlineService, AirlineService>();

            services.AddScoped<IVisaService, VisaService>();
            services.AddScoped<IRouteService, RouteService>();
            services.AddScoped<IRuleContainer, RuleContainer>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Test donde se injectan las dependencias deben ser añadidos aqui
            services.AddTransient<BorderCrossingServiceTest>();
            services.AddTransient<CountryServiceTest>();

            //Automapper
            services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(typeof(CountryProfile));
            services.AddAutoMapper(typeof(DestinationProfile));
            services.AddAutoMapper(typeof(DestinationTypeProfile));

        }
    }

}
