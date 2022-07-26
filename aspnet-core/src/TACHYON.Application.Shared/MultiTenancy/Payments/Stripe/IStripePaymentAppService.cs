using System.Threading.Tasks;
using Abp.Application.Services;
using TACHYON.MultiTenancy.Payments.Dto;
using TACHYON.MultiTenancy.Payments.Stripe.Dto;

namespace TACHYON.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}