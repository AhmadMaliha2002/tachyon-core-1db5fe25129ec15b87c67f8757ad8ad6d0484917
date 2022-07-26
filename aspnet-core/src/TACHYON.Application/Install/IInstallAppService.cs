using System.Threading.Tasks;
using Abp.Application.Services;
using TACHYON.Install.Dto;

namespace TACHYON.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}