using System;
using Microsoft.EntityFrameworkCore;
using Trips.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Trip_Designer.Data
{
    public class TripDbContext : IdentityDbContext <IdentityUser, IdentityRole, string>
    {
        public DbSet<Trip> Itineraries {get; set;}
          public TripDbContext(DbContextOptions<TripDbContext> options) : base(options)
        {
        }
    }
}