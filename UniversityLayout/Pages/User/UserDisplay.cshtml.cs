using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityLayout.Data;
using UniversityLayout.Model.DataAnnotations;

namespace UniversityLayout.Pages.User
{
    public class UserDisplayModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public UserDisplayModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<FormA> forma { get; set; }
        public void OnGet(int formid)
        {
            forma = _db.FormA.ToList();
        }
    }
}
