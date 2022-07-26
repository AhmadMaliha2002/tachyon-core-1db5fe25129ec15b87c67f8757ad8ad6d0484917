using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TACHYON
{
    [DependsOn(typeof(TACHYONCoreSharedModule))]
    public class TACHYONApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TACHYONApplicationSharedModule).GetAssembly());
        }
    }
}