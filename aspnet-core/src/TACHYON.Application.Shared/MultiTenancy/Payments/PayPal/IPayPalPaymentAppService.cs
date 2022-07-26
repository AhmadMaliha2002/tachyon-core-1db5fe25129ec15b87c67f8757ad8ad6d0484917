using System.Threading.Tasks;
using Abp.Application.Services;
using TACHYON.MultiTenancy.Payments.PayPal.Dto;

namespace TACHYON.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
