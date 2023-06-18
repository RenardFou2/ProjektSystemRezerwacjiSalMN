namespace ProjektSystemRezerwacjiSalMN.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime Data1 { get; set; }
        public DateTime Data2 { get; set; }
        public int? RoomId { get; set; }
        public virtual Room? Room { get; set; }
    }
}
