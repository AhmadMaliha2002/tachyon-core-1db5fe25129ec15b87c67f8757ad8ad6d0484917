using Abp;

namespace TACHYON
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="TACHYONDomainServiceBase"/>.
    /// For application services inherit TACHYONAppServiceBase.
    /// </summary>
    public abstract class TACHYONServiceBase : AbpServiceBase
    {
        protected TACHYONServiceBase()
        {
            LocalizationSourceName = TACHYONConsts.LocalizationSourceName;
        }
    }
}