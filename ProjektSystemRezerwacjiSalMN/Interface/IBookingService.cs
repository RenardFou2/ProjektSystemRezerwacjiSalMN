using ProjektSystemRezerwacjiSalMN.Data;
using ProjektSystemRezerwacjiSalMN.Models;

namespace ProjektSystemRezerwacjiSalMN.Interface
{
    public interface IBookingService
    {
        public bool CheckDateCompatibility(Booking Booking);
    }
}
