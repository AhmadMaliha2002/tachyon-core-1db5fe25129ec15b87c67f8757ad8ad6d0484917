using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TACHYON
{
    public class TACHYONClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TACHYONClientModule).GetAssembly());
        }
    }
}
