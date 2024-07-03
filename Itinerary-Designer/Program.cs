using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Trips.Data;
using Exchange.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "server=localhost;user=designer;password=K9l0m15?/;database=itinerary";

var serverVersion = new MySqlServerVersion(new Version(8, 0, 37));

builder.Services.AddRazorPages();

// var connectionString = builder.Configuration.GetConnectionString("ItineraryDbContextConnection");builder.Services.AddDbContext<EventDbContext>(options => options.UseSqlServer(connectionString));builder.Services.AddDefaultIdentity<IdentityUser>
// (options => optionsSignInRequireConfirmedAccount = true).AddEntityFrameworkStores<ItineraryDbContext>();

builder.Services.AddDbContext<TripDbContext>(options => options.UseSqlServer(connectionString));
builder
    .Services.AddDefaultIdentity<IdentityUser>(options =>
        options.SignIn.RequireConfirmedAccount = true
    )
    .AddEntityFrameworkStores<TripDbContext>();

var commentConnectionString = "server=localhost;user=designer;password=K9l0m15?/;database=comments"; // Adjust this connection string as needed
builder.Services.AddDbContext<TripDbContext>(options =>
    options.UseMySql(commentConnectionString, serverVersion)
);

// Add ExchangeRatesApiService to the services container
builder.Services.AddTransient<ExchangeRatesApiService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
