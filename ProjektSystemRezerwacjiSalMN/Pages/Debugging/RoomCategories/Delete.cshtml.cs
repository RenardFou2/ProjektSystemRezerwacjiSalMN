using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjektSystemRezerwacjiSalMN.Data;
using ProjektSystemRezerwacjiSalMN.Models;

namespace ProjektSystemRezerwacjiSalMN.Pages.Debugging.RoomCategories
{
    public class DeleteModel : PageModel
    {
        private readonly ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext _context;

        public DeleteModel(ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public RoomCategory RoomCategory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RoomCategory == null)
            {
                return NotFound();
            }

            var roomcategory = await _context.RoomCategory.FirstOrDefaultAsync(m => m.Id == id);

            if (roomcategory == null)
            {
                return NotFound();
            }
            else 
            {
                RoomCategory = roomcategory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.RoomCategory == null)
            {
                return NotFound();
            }
            var roomcategory = await _context.RoomCategory.FindAsync(id);

            if (roomcategory != null)
            {
                RoomCategory = roomcategory;
                _context.RoomCategory.Remove(RoomCategory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
