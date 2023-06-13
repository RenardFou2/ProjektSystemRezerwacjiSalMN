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
    public class IndexModel : PageModel
    {
        private readonly ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext _context;

        public IndexModel(ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Building> Building { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Building != null)
            {
                Building = await _context.Building.ToListAsync();
            }
        }
    }
}
