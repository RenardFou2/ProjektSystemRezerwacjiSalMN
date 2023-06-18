using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjektSystemRezerwacjiSalMN.Data;
using ProjektSystemRezerwacjiSalMN.Models;
using ProjektSystemRezerwacjiSalMN.Interface;
using Microsoft.EntityFrameworkCore.Storage;

namespace ProjektSystemRezerwacjiSalMN.Pages.Debugging.Bookings
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IBookingService _bookingService;
        public CreateModel(ApplicationDbContext context, IBookingService bookingService)
        {
            _context = context;
            _bookingService = bookingService;
        }

        public IActionResult OnGet(int id)
        {
        ViewData["RoomId"] = new SelectList(_context.Room, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Booking == null || Booking == null)
            {
                return Page();
            }

            if (!_bookingService.CheckDateCompatibility(Booking)) {
                _context.Booking.Add(Booking);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }
            
            return RedirectToPage("./Index");
        }
    }
}
