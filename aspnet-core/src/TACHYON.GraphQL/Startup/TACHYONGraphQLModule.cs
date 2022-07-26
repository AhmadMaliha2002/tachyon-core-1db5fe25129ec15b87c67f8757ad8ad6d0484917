using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TACHYON.Startup
{
    [DependsOn(typeof(TACHYONCoreModule))]
    public class TACHYONGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TACHYONGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}