using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityLayout.Data;
using UniversityLayout.Model;
using UniversityLayout.Model.DataAnnotations;

namespace UniversityLayout.Pages.AppForm
{
    public class FormModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public FormModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public FormA FormA { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.FormA.Add(FormA);
            _db.SaveChanges();

            return RedirectToPage("/ThankYou/ThankYouPage");
        }
    }
}
