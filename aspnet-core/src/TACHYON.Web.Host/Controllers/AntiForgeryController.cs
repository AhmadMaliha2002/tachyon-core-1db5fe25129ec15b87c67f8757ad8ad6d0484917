using Microsoft.AspNetCore.Antiforgery;

namespace TACHYON.Web.Controllers
{
    public class AntiForgeryController : TACHYONControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
