using Microsoft.EntityFrameworkCore;
using OptiTourRoutesWebsite.Models;

namespace OptiTourRoutesWebsite.DB
{
    public class TourDbContext : DbContext
    {
        public TourDbContext(DbContextOptions<TourDbContext> options) : base(options)
        { 
        
        }

        public DbSet<TouristSpot> TouristSpots { get; set; }
    }
}
