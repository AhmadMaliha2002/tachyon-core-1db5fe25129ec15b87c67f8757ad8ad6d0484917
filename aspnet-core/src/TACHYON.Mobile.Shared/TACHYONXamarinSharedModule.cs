using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TACHYON
{
    [DependsOn(typeof(TACHYONClientModule), typeof(AbpAutoMapperModule))]
    public class TACHYONXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TACHYONXamarinSharedModule).GetAssembly());
        }
    }
}