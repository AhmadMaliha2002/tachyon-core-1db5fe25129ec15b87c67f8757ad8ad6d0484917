using System.Threading.Tasks;
using TACHYON.Security.Recaptcha;

namespace TACHYON.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
