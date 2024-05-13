using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityLayout.Data;
using UniversityLayout.Model;
using UniversityLayout.Model.DataAnnotations;

namespace UniversityLayout.Pages.AppForm
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public FormA forma { get; set; }
        public void OnGet() { }

        public IActionResult OnPost()
        {
            forma.CreatedAt = forma.UpdatedAt = DateTime.Now;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.FormA.Add(forma);
            _db.SaveChanges();
            TempData["success"] = "New Form has been created.";
            return RedirectToPage("/ThankYou/ThankYouPage");
        }
    }
}
