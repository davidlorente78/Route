namespace Test
{
    using Application.Mapper;
    using Application.Mapper.Generic;
    using Application.Profiles;
    using Domain.Authorization;
    using Domain.Repositories;
    using DomainServices.AirlineService;
    using DomainServices.Authorization;
    using DomainServices.CountryService;
    using DomainServices.DestinationService;
    using DomainServices.Generic;
    using MassTransit;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.IdentityModel.Tokens;
    using RouteDataManager.Controllers;
    using RouteDataManager.Repositories;
    using RouteDataManager.Repositories.Transport.Aviation;
    using RouteDataManager.Repositories.Transport.Railway;
    using System.Text;
    using Test.Services;
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
            services.AddScoped(typeof(IVisaMapper), typeof(VisaMapper));
            services.AddScoped(typeof(IRailwayLineMapper), typeof(RailwayLineMapper));
            services.AddScoped(typeof(IRailwayBranchMapper), typeof(RailwayBranchMapper));
            services.AddScoped(typeof(IRailwayStationMapper), typeof(RailwayStationMapper));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IBorderCrossingRepository, BorderCrossingRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            services.AddScoped<IDestinationTypeRepository, DestinationTypeRepository>();
            services.AddScoped<IRailwayStationRepository, RailwayStationRepository>();
            services.AddScoped<IAirportRepository, AirportRepository>();
            services.AddScoped<IAirportTypeRepository, AirportTypeRepository>();
            services.AddScoped<IAirlineRepository, AirlineRepository>();
            services.AddScoped<IVisaRepository, VisaRepository>();
            services.AddScoped<IRailwayLineRepository, RailwayLineRepository>();
            services.AddScoped<IRailwayBranchRepository, RailwayBranchRepository>();
            services.AddScoped<IRailwayStationRepository, RailwayStationRepository>();


            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IDestinationTypeService, DestinationTypeService>();
            services.AddScoped<IAirportService, AirportService>();
            services.AddScoped<IAirportTypeService, AirportTypeService>();
            services.AddScoped<IAirlineService, AirlineService>();
            services.AddScoped<IRailwayLineService, RailwayLineService>();
            services.AddScoped<IRailwayBranchService, RailwayBranchService>();
            services.AddScoped<IRailwayStationService, RailwayStationService>();

            services.AddScoped<IVisaService, VisaService>();
            services.AddScoped<IRouteService, RouteService>();
            services.AddScoped<IRuleContainer, RuleContainer>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Test donde se injectan las dependencias deben ser añadidos aqui
            services.AddTransient<BorderCrossingServiceTest>();
            services.AddTransient<CountryServiceTest>();

            // Automapper
            services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(typeof(CountryProfile));
            services.AddAutoMapper(typeof(DestinationProfile));
            services.AddAutoMapper(typeof(DestinationTypeProfile));
            services.AddAutoMapper(typeof(VisaProfile));

            // RabbitMQ
            
            services.AddMassTransit(x =>
            {              
                x.AddConsumer<AirportsController>();
                x.AddConsumer<RailwayStationsController>();

                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host("localhost", "/", h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });

                    cfg.ReceiveEndpoint("EntitiesEventsQueue", e =>
                    {
                        e.ConfigureConsumer<AirportsController>(context);
                        e.ConfigureConsumer<RailwayStationsController>(context);
                    });
                });
            });

            services.AddScoped<AirportsController>();
            services.AddScoped<CountriesController>();
            services.AddScoped<DestinationsController>();
            services.AddScoped<RailwayStationsController>();

            services.AddMassTransitHostedService();

            services.AddSingleton<IPublishEndpoint>(provider => provider.GetRequiredService<IBusControl>());
            services.AddSingleton<ISendEndpointProvider>(provider => provider.GetRequiredService<IBusControl>());
            services.AddSingleton<IBus>(provider => provider.GetRequiredService<IBusControl>());

            services.AddAuthorization();

   

            services
                .AddIdentityCore<ApiUser>() 
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<UserManager<ApiUser>>();

            services.AddScoped<IAuthManager, AuthManager>();

            services.AddScoped(typeof(ILogger<>), typeof(Logger<>));

            services.AddLogging(builder =>
            {
                builder.AddConsole();
                builder.AddDebug();
            });
        }
    }
}
