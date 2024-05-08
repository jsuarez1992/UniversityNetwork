using Microsoft.EntityFrameworkCore;
using UniversityLayout.Model;
using UniversityLayout.Model.DataAnnotations;

namespace UniversityLayout.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<FormA> FormA { get; set; }
    }
}
