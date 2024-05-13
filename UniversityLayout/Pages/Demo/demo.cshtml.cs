using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UniversityLayout.Pages.Demo
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();

        }
    }
}
