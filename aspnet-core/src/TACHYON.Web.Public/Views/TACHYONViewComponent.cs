using Abp.AspNetCore.Mvc.ViewComponents;

namespace TACHYON.Web.Public.Views
{
    public abstract class TACHYONViewComponent : AbpViewComponent
    {
        protected TACHYONViewComponent()
        {
            LocalizationSourceName = TACHYONConsts.LocalizationSourceName;
        }
    }
}