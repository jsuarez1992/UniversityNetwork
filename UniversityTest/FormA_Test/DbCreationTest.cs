using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLayout.Data;
using Xunit;

namespace UniversityTest.FormA_Test
{
    public class DbCreationTest
    {
        [Fact]
        public void CheckConnection()
        {
            var options = ConnectionSettingsTest.GetConnection();
            using (var context = new ApplicationDbContext(options))
            {
                if (context != null)
                {
                    context.Database.EnsureCreated();
                }
                Assert.NotNull(context);
            }

        }
    }
}
