using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace TACHYON.Web.Public.Views
{
    public abstract class TACHYONRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TACHYONRazorPage()
        {
            LocalizationSourceName = TACHYONConsts.LocalizationSourceName;
        }
    }
}
