using Microsoft.EntityFrameworkCore;

namespace BloodBank.Models
{
    public class BloodBankContext : DbContext 
    {
        public BloodBankContext(DbContextOptions<BloodBankContext> options) 
            : base (options)
        {
        }
        public DbSet<Donors> donors { get; set; }
        public DbSet<Donation> donations { get; set; }
        public DbSet<BloodStorage> bloodStorages { get; set; }
        public DbSet<Address> addresses { get; set; } 
    }
}
