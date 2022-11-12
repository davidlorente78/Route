using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using Traveller.DomainServices;
using Traveller.RouteService;
using Traveller.RuleService;


// Add services to the container.

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Finally, let’s register these Interfaces to the respective implementaions in the Startup.cs of the WebApi Project. Navigate to Startup.cs/ConfigureServices Method and add these lines.

#region Repositories
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IBorderCrossingRepository, BorderCrossingRepository>();
builder.Services.AddTransient<ICountryRepository, CountryRepository>();
builder.Services.AddTransient<IDestinationRepository, DestinationRepository>();


builder.Services.AddTransient<IDestinationRepository, DestinationRepository>();


//Note that, Here we are injecting a private AppplicationContext. Let’s wire up or controllers with these Repositories. Ideally you would want to have a service layer between the Repository and Controllers. But, to keep things fairly simple, we will avoid the service layer now.
//Before that, let’s not forget to register the IUnitofWork Interface in our Application. Navigate to Startup.cs/ConfigureServices Method and add this line.


builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<ICountryService, CountryService>();
builder.Services.AddTransient<IVisaService, VisaService>();
builder.Services.AddTransient<IRouteService, RouteService>();
builder.Services.AddTransient<IRuleContainer , RuleContainer>();





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
app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
