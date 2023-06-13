using System.ComponentModel.DataAnnotations;

namespace ProjektSystemRezerwacjiSalMN.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<RoomEquipment>? RoomEquipments { get; set; }
    }
}
