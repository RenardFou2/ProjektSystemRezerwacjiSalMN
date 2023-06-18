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
    public class IndexModel : PageModel
    {
        private readonly ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext _context;

        public IndexModel(ProjektSystemRezerwacjiSalMN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<RoomCategory> RoomCategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.RoomCategory != null)
            {
                RoomCategory = await _context.RoomCategory
                .Include(r => r.Category)
                .Include(r => r.Room).ToListAsync();
            }
        }
    }
}
