using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TACHYON
{
    [DependsOn(typeof(TACHYONXamarinSharedModule))]
    public class TACHYONXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TACHYONXamarinIosModule).GetAssembly());
        }
    }
}