using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TACHYON.Configuration;
using TACHYON.Web;

namespace TACHYON.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TACHYONDbContextFactory : IDesignTimeDbContextFactory<TACHYONDbContext>
    {
        public TACHYONDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TACHYONDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            TACHYONDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TACHYONConsts.ConnectionStringName));

            return new TACHYONDbContext(builder.Options);
        }
    }
}