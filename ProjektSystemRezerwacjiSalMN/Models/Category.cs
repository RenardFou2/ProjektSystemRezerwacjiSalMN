using System.ComponentModel.DataAnnotations;

namespace ProjektSystemRezerwacjiSalMN.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<RoomCategory>? RoomCategories { get; set; }
    }
}
