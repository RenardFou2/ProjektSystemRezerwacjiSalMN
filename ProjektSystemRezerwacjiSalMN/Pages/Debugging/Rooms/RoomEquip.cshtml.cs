using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjektSystemRezerwacjiSalMN.Models;

namespace ProjektSystemRezerwacjiSalMN.Pages.Debugging.Rooms
{
    public class RoomEquipModel : PageModel
    {
        private readonly ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext _context;

        public RoomEquipModel(ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<Models.Equipment> RoomEquipment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Equipment == null)
            {
                return NotFound();
            }

            var roomequipment = await _context.Equipment.Where(m => m.RoomId == id).ToListAsync();

            if (roomequipment == null)
            {
                return NotFound();
            }
            RoomEquipment = roomequipment;
            return Page();
        }
    }
}
