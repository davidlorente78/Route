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
using Microsoft.IdentityModel.Tokens;
using RouteDataManager.Controllers;
using RouteDataManager.Repositories;
using RouteDataManager.Repositories.DbInitializer;
using RouteDataManager.Repositories.Transport.Aviation;
using RouteDataManager.Repositories.Transport.Railway;
using System.Text;
using Traveller.DomainServices;
using Traveller.RouteService;
using Traveller.RuleService;


// Add services to the container.

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationContext>(
    options =>
    options
    .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
  );

builder.Services.AddScoped(typeof(IGenericMapper<,>), typeof(GenericMapper<,>));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));

builder.Services.AddScoped(typeof(ICountryMapper), typeof(CountryMapper));
builder.Services.AddScoped(typeof(IDestinationMapper), typeof(DestinationMapper));
builder.Services.AddScoped(typeof(IDestinationTypeMapper), typeof(DestinationTypeMapper));
builder.Services.AddScoped(typeof(IAirportMapper), typeof(AirportMapper));
builder.Services.AddScoped(typeof(IAirportTypeMapper), typeof(AirportTypeMapper));
builder.Services.AddScoped(typeof(IAirlineMapper), typeof(AirlineMapper));
builder.Services.AddScoped(typeof(IVisaMapper), typeof(VisaMapper));
builder.Services.AddScoped(typeof(INationalityMapper), typeof(NationalityMapper));

builder.Services.AddScoped(typeof(IRailwayLineMapper), typeof(RailwayLineMapper));
builder.Services.AddScoped(typeof(IRailwayBranchMapper), typeof(RailwayBranchMapper));
builder.Services.AddScoped(typeof(IRailwayStationMapper), typeof(RailwayStationMapper));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IBorderCrossingRepository, BorderCrossingRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<IDestinationRepository, DestinationRepository>();
builder.Services.AddScoped<IDestinationTypeRepository, DestinationTypeRepository>();
builder.Services.AddScoped<IRailwayStationRepository, RailwayStationRepository>();
builder.Services.AddScoped<IAirportRepository, AirportRepository>();
builder.Services.AddScoped<IAirportTypeRepository, AirportTypeRepository>();
builder.Services.AddScoped<IAirlineRepository, AirlineRepository>();
builder.Services.AddScoped<IVisaRepository, VisaRepository>();
builder.Services.AddScoped<INationalityRepository, NationalityRepository>();

builder.Services.AddScoped(typeof(IRailwayLineRepository), typeof(RailwayLineRepository));
builder.Services.AddScoped(typeof(IRailwayBranchRepository), typeof(RailwayBranchRepository));
builder.Services.AddScoped(typeof(IRailwayStationRepository), typeof(RailwayStationRepository));

builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IDestinationService, DestinationService>();
builder.Services.AddScoped<IDestinationTypeService, DestinationTypeService>();
builder.Services.AddScoped<IAirportService, AirportService>();
builder.Services.AddScoped<IAirportTypeService, AirportTypeService>();
builder.Services.AddScoped<IAirlineService, AirlineService>();
builder.Services.AddScoped<INationalityService, NationalityService>();
builder.Services.AddScoped<IRailwayLineService, RailwayLineService>();
builder.Services.AddScoped<IRailwayBranchService, RailwayBranchService>();
builder.Services.AddScoped<IRailwayStationService, RailwayStationService>();

builder.Services.AddScoped<IVisaService, VisaService>();
builder.Services.AddScoped<IRouteService, RouteService>();
builder.Services.AddScoped<IRuleContainer, RuleContainer>();

#region AutoMapper

//You define the configuration using profiles.
//And then you let AutoMapper know in what assemblies are those profiles defined by calling the IServiceCollection extension method AddAutoMapper at startup:
builder.Services.AddAutoMapper(typeof(CountryProfile));
//Now you can inject AutoMapper at runtime into your services/controllers

#endregion


#region RabbitMQ

//https://www.erlang.org/downloads
//https://www.rabbitmq.com/download.html
//rabbitmqctl status para verificar que este ejecutandose el servicio
//http://localhost:15672 acceso a consola administracion web
//Eliminar colas desde la consola de administracion

builder.Services.AddMassTransit(x =>
{
    // Configurar MassTransit 
    // Añadir Consumers
    x.AddConsumer<AirportsController>();
    x.AddConsumer<RailwayStationsController>();


    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("localhost", "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });

        //Configurar la cola en la que se recibirán los mensajes.
        cfg.ReceiveEndpoint("EntitiesEventsQueue", e =>
        {
            //Usamos el método ConfigureConsumer para registrar el consumidor AirportsController con MassTransit.
            e.ConfigureConsumer<AirportsController>(context);
            e.ConfigureConsumer<RailwayStationsController>(context);
        });
    });
});

builder.Services.AddScoped<AirportsController>();
builder.Services.AddScoped<CountriesController>();
builder.Services.AddScoped<DestinationsController>();
builder.Services.AddScoped<RailwayStationsController>();

builder.Services.AddMassTransitHostedService();

builder.Services.AddSingleton<IPublishEndpoint>(provider => provider.GetRequiredService<IBusControl>());
builder.Services.AddSingleton<ISendEndpointProvider>(provider => provider.GetRequiredService<IBusControl>());
builder.Services.AddSingleton<IBus>(provider => provider.GetRequiredService<IBusControl>());

#endregion


#region Global Authentication Settings

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

})
    .AddJwtBearer(o =>
    {
        o.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

//This way our API will know that we intend to support authorization
builder.Services.AddAuthorization();

//Register our identity-related services. We are user default user Type called IdentityUser and default role. The Data Store associated will be ApplicationContext
builder.Services
    .AddIdentityCore<ApiUser>() //Aqui antes estaba Identity User y es quiza por eso que no coinciden y explotan
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationContext>()
    .AddDefaultTokenProviders();


//Linea omitida en el libro y en todas partes ... Me la ha chivado ChatGPT
builder.Services.AddScoped<UserManager<ApiUser>>();

builder.Services.AddScoped<IAuthManager, AuthManager>();
#endregion


var app = builder.Build();

//Create Scope and Initialize Data Base

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ApplicationContext>();

    DbInitializer.Initialize(context);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


//Include middleware for Bearer Token
app.UseAuthentication();
app.UseAuthorization();

app.Run();