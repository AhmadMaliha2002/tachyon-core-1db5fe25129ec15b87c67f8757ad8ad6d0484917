using Microsoft.Extensions.Configuration;

namespace TACHYON.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
