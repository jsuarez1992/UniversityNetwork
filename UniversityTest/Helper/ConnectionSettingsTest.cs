using Microsoft.EntityFrameworkCore;
using UniversityLayout.Data;


namespace UniversityTest
{
    public static class ConnectionSettingsTest
    {
        public static DbContextOptions<ApplicationDbContext> GetConnection()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlServer("Server=KLA-KPCAR1-06;Database=universityform;Trusted_Connection=True;");
            return builder.Options;

        }
    }
}