using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjektSystemRezerwacjiSalMN.Pages
{
    [Authorize]
    public class DebugIndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
