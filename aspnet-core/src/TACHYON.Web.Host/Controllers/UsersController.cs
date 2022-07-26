using Abp.AspNetCore.Mvc.Authorization;
using TACHYON.Authorization;
using TACHYON.Storage;
using Abp.BackgroundJobs;

namespace TACHYON.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}