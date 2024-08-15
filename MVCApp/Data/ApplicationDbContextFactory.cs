using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MVCApp.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<MVCAppContext>
    {
        private IConfiguration _configuration { get; }
        // Create Constructor

        public ApplicationDbContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MVCAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MVCAppContext>();
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);

            return new MVCAppContext(optionsBuilder.Options);
        }
    }
}
