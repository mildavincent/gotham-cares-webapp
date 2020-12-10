using GothamCares.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GothamCares.DataServices.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //constructor for reference in startup
        }

        public AppDbContext()
        {
        }

        public DbSet<Outlet> Outlets { get; set; }
        public DbSet<FoodPacket> FoodPackets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //dataseeder is for dummy values

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedPrimaryData();
        }

        //connecting to db while querying
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host = localhost; Database=gotham-cares-db;Username=postgres;Password=Experion@123");
    }
}
