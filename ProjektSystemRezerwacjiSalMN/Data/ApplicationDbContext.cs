using ProjektSystemRezerwacjiSalMN.Models;
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
        public DbSet<Room> Room { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<Booking> Booking { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<RoomCategory>()
                .HasOne<Room>(rc => rc.Room)
                .WithMany(r => r.RoomCategories)
                .HasForeignKey(r => r.RoomId);
            builder.Entity<RoomCategory>()
                .HasOne<Category>(c => c.Category)
                .WithMany(c => c.RoomCategories)
                .HasForeignKey(c => c.CategoryId);


            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" });
        }

        public DbSet<ProjektSystemRezerwacjiSalMN.Models.Equipment>? Equipment { get; set; }

        public DbSet<ProjektSystemRezerwacjiSalMN.Models.Category>? Category { get; set; }

        public DbSet<ProjektSystemRezerwacjiSalMN.Models.RoomCategory>? RoomCategory { get; set; }
    }
}