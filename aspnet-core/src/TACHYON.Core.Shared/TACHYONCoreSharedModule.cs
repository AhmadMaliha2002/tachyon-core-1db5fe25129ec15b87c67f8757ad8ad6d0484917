using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TACHYON
{
    public class TACHYONCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TACHYONCoreSharedModule).GetAssembly());
        }
    }
}