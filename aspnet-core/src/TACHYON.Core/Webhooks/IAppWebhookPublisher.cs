using System.Threading.Tasks;
using TACHYON.Authorization.Users;

namespace TACHYON.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
