using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjektSystemRezerwacjiSalMN.Data;
using ProjektSystemRezerwacjiSalMN.Models;

namespace ProjektSystemRezerwacjiSalMN.Pages.Debugging.Buildings
{
    public class DeleteModel : PageModel
    {
        private readonly ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext _context;

        public DeleteModel(ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Building Building { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Building == null)
            {
                return NotFound();
            }

            var building = await _context.Building.FirstOrDefaultAsync(m => m.Id == id);

            if (building == null)
            {
                return NotFound();
            }
            else 
            {
                Building = building;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Building == null)
            {
                return NotFound();
            }
            var building = await _context.Building.FindAsync(id);

            if (building != null)
            {
                Building = building;
                _context.Building.Remove(Building);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
