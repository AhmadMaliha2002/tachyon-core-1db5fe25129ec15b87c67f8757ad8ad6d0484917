using Abp.AspNetCore.Mvc.Views;

namespace TACHYON.Web.Views
{
    public abstract class TACHYONRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected TACHYONRazorPage()
        {
            LocalizationSourceName = TACHYONConsts.LocalizationSourceName;
        }
    }
}
