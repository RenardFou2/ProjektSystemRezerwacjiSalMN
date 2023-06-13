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
    public class IndexModel : PageModel
    {
        private readonly ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext _context;

        public IndexModel(ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ProjektSystemRezerwacjiSalMN.Models.Equipment> Equipment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Equipment != null)
            {
                Equipment = await _context.Equipment
                .Include(e => e.Room).ToListAsync();
            }
        }
    }
}
