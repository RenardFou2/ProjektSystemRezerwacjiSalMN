using ProjektSystemRezerwacjiSalMN.Data;
using ProjektSystemRezerwacjiSalMN.Interface;
using ProjektSystemRezerwacjiSalMN.Models;

namespace ProjektSystemRezerwacjiSalMN.Services
{
    public class BookingService : IBookingService
    {
        private readonly ApplicationDbContext _context;
        public BookingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool CheckDateCompatibility(Booking Booking)
        {
            DateTime now = DateTime.Now;
            DateTime twoYears = DateTime.Now.AddYears(2);

            if (Booking.Data1 >= Booking.Data2 || Booking.Data1 <= now || Booking.Data1 > twoYears )
            {
                return true;
            }
            
            var roombookings = _context.Booking.Where(m => m.RoomId == Booking.RoomId).ToList();

            if (roombookings == null)
            {
                return false;
            }
            foreach (var item in roombookings)
            {
                if (Booking.Data1 >= item.Data1 && Booking.Data1 < item.Data2 || Booking.Data2 >= item.Data1 && Booking.Data2 < item.Data2 )
                {
                    return true;
                }
            }
            return false;
        }

    }
}