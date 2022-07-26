using Microsoft.AspNetCore.Mvc;
using TACHYON.Web.Controllers;

namespace TACHYON.Web.Public.Controllers
{
    public class AboutController : TACHYONControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}