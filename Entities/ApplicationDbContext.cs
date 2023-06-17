using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Facility> Facilities { get; set; }
        public DbSet<FacilityBooking> FacilityBookings { get; set; }

    }
}