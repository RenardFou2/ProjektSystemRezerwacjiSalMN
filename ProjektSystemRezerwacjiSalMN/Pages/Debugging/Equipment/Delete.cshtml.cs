using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjektSystemRezerwacjiSalMN.Data;
using ProjektSystemRezerwacjiSalMN.Models;

namespace ProjektSystemRezerwacjiSalMN.Pages.Debugging.Equipment
{
    public class DeleteModel : PageModel
    {
        private readonly ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext _context;

        public DeleteModel(ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ProjektSystemRezerwacjiSalMN.Models.Equipment Equipment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Equipment == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipment.FirstOrDefaultAsync(m => m.Id == id);

            if (equipment == null)
            {
                return NotFound();
            }
            else 
            {
                Equipment = equipment;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Equipment == null)
            {
                return NotFound();
            }
            var equipment = await _context.Equipment.FindAsync(id);

            if (equipment != null)
            {
                Equipment = equipment;
                _context.Equipment.Remove(Equipment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
