using Abp.Application.Services;
using TACHYON.Dto;
using TACHYON.Logging.Dto;

namespace TACHYON.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
