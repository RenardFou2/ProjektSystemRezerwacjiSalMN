using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjektSystemRezerwacjiSalMN.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Street { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(6)]
        [Column(TypeName = "varchar(6)")]
        public string ZipCode { get; set; }
        [Required]
        [MaxLength(2)]
        public string Country { get; set; }
        public int BuildingId { get; set; }
        public virtual Building Building { get; set; }

        public ICollection<RoomCategory>? RoomCategories { get; set; }
        public ICollection<RoomEquipment>? RoomEquipments { get; set; }



    }
}
