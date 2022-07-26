using System.Threading.Tasks;
using Abp.Application.Services;

namespace TACHYON.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
