using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjektSystemRezerwacjiSalMN.Data;
using ProjektSystemRezerwacjiSalMN.Models;

namespace ProjektSystemRezerwacjiSalMN.Pages.Debugging.Buildings
{
    public class CreateModel : PageModel
    {
        private readonly ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext _context;

        public CreateModel(ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Building Building { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Building == null || Building == null)
            {
                return Page();
            }

            _context.Building.Add(Building);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
