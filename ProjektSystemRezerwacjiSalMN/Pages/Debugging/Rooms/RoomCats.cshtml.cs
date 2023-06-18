using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjektSystemRezerwacjiSalMN.Models;

namespace ProjektSystemRezerwacjiSalMN.Pages.Debugging.Rooms
{
    public class RoomCatsModel : PageModel
    {
        private readonly ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext _context;

        public RoomCatsModel(ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<RoomCategory> RoomCategory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RoomCategory == null)
            {
                return NotFound();
            }

            var roomcategory = await _context.RoomCategory.Where(m => m.RoomId == id)
                .Include(m => m.Category)
                .ToListAsync();

            if (roomcategory == null)
            {
                return NotFound();
            }
            RoomCategory = roomcategory;
            return Page();
        }
    }
}
