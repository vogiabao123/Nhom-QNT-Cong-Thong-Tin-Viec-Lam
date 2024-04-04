using DACS_Web_Viec_Lam.Models;
using Microsoft.EntityFrameworkCore;

namespace DACS_Web_Viec_Lam.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employer> Employers { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<JobSeeker> JobSeeker { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCredentials> UserCredentials { get; set; }

    }
}
