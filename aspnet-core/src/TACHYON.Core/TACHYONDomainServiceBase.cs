using Abp.Domain.Services;

namespace TACHYON
{
    public abstract class TACHYONDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected TACHYONDomainServiceBase()
        {
            LocalizationSourceName = TACHYONConsts.LocalizationSourceName;
        }
    }
}
