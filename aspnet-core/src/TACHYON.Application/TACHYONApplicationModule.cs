using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TACHYON.Authorization;

namespace TACHYON
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(TACHYONApplicationSharedModule),
        typeof(TACHYONCoreModule)
        )]
    public class TACHYONApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TACHYONApplicationModule).GetAssembly());
        }
    }
}