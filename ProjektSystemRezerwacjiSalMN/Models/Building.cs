using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjektSystemRezerwacjiSalMN.Models
{
    public class Building
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        public string ZIPCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string Street { get; set; }
        [Required]
        [MaxLength(50)]
        public string StreetNumber { get; set; }
        

        public virtual ICollection<Room>? Rooms { get; set; }
    }
}
