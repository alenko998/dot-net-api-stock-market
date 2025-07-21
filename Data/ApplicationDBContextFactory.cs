using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace api.Data
{
    public class ApplicationDBContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    {
        public ApplicationDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=TeddyDB;User Id=sa;Password=YourPassword123!;TrustServerCertificate=True;");

            return new ApplicationDBContext(optionsBuilder.Options);
        }
    }
}
