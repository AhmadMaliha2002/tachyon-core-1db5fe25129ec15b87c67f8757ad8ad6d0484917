using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using TACHYON.Configure;
using TACHYON.Startup;
using TACHYON.Test.Base;

namespace TACHYON.GraphQL.Tests
{
    [DependsOn(
        typeof(TACHYONGraphQLModule),
        typeof(TACHYONTestBaseModule))]
    public class TACHYONGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TACHYONGraphQLTestModule).GetAssembly());
        }
    }
}