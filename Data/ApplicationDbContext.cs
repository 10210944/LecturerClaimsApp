using LecturerClaimsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LecturerClaimsApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define your DbSets here
        public DbSet<LecturerClaim> LecturerClaims { get; set; }
    }
}

namespace LecturerClaimsApp.Models
{
    public class LecturerClaimsAppContext : DbContext
    {
        public LecturerClaimsAppContext(DbContextOptions<LecturerClaimsAppContext> options)
            : base(options)
        {
        }

        public DbSet<LecturerClaim> LecturerClaims { get; set; }
    }
}
