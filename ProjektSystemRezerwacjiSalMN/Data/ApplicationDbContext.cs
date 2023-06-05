using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProjektSystemRezerwacjiSalMN.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the administrator role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" });
        }
    }
}