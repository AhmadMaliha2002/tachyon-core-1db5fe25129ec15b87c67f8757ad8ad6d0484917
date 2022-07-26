using System.Threading.Tasks;
using Abp.Webhooks;

namespace TACHYON.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
