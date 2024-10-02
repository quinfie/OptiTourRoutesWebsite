using Microsoft.EntityFrameworkCore;
using OptiTourRoutesWebsite.Models;

namespace OptiTourRoutesWebsite.DB
{
    public class TourDbContext : DbContext
    {
        internal object TouristRoutes;

        public TourDbContext(DbContextOptions<TourDbContext> options) : base(options)
        { 
        
        }

        public DbSet<TouristSpot> TouristSpots { get; set; }
    }
}
