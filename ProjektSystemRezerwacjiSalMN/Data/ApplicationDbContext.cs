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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Ustawiam RoomID i CategoryID jako klucze
            builder.Entity<RoomCategory>().HasKey(rc => new { rc.RoomId, rc.CategoryId });
            builder.Entity<RoomCategory>()
                .HasOne<Room>(rc => rc.Room) // dla jednego pokoju
                .WithMany(r => r.RoomCategories) // jest wiele RoomCategories
                .HasForeignKey(r => r.RoomId); // a powizanie jest realizowane przez klucz obcy RoomID
            builder.Entity<RoomCategory>()
                .HasOne<Category>(c => c.Category) // dla jednej kategorii
                .WithMany(c => c.RoomCategories) // jest wiele RoomCategories
                .HasForeignKey(c => c.CategoryId); // a powizanie jest realizowane przez klucz obcy CategoriesId


            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" });
        }

        public DbSet<ProjektSystemRezerwacjiSalMN.Models.Equipment>? Equipment { get; set; }
    }
}