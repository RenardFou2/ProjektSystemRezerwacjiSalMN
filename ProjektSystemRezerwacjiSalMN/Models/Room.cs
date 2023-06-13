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
        public string Name { get; set; }
        [Required]
        public int Capacity { get; set; }
        public int BuildingId { get; set; }
        public virtual Building Building { get; set; }

        public ICollection<RoomCategory>? RoomCategories { get; set; }
        public virtual ICollection<Equipment>? Equipments { get; set; }



    }
}
