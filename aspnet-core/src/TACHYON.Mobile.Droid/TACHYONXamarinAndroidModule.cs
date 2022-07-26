using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TACHYON
{
    [DependsOn(typeof(TACHYONXamarinSharedModule))]
    public class TACHYONXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TACHYONXamarinAndroidModule).GetAssembly());
        }
    }
}