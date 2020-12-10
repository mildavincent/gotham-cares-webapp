using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GothamCares.DataServices.Context
{
    public static class DataSeeder
    {
        /// <summary>
        /// Ensures the seed data.
        /// </summary>
        /// <param name="scope">The scope.</param>
        public static void EnsureSeedData(IServiceScope scope)
        {
            // Ensure seed data.
        }

        /// <summary>
        /// Seeds the primary data.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        public static void SeedPrimaryData(this ModelBuilder modelBuilder)
        {
            // Seed primary data.
        }
    }
}
