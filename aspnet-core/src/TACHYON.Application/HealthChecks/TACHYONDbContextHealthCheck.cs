using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using TACHYON.EntityFrameworkCore;

namespace TACHYON.HealthChecks
{
    public class TACHYONDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public TACHYONDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("TACHYONDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("TACHYONDbContext could not connect to database"));
        }
    }
}
